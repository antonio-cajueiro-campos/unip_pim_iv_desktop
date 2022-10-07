using Microsoft.AspNetCore.SignalR.Client;
using Model = unip_pim_iv_desktop.Models;

namespace unip_pim_iv_desktop.Services;
internal class ChatService
{
    public HubConnection Connection;
    public List<Model.Chat> ChatList = new List<Model.Chat>();
    public List<Model.Chat> StartedChatList = new List<Model.Chat>();
    public long SelectedChatId = 0;
    public long UserId = 0;
    public int TypingDelayMillis = 700;
    public bool IsWriting = false;
    public bool IsChatMode = false;

    public ChatService()
    {
        Connection = new HubConnectionBuilder()
            .WithUrl($"https://tsb-portal.herokuapp.com/websocketchat?userId={UserId}")
            .Build();

        StartConnection();
    }

    public void StartConnection()
    {
        try
        {
            Connection.On("newMessage", (Model.Message message, long chatId) =>
            {
                RenderMessageOnChat(message, chatId);
            });

            Connection.On("closeSession", () =>
            {
                CloseSession();
            });

            Connection.On("updateChatList", (List<Model.Chat> chatList) =>
            {
                ChatList = chatList;
            });

            Connection.On("startedChats", (List<Model.Chat> startedChatList) =>
            {
                StartedChatList = startedChatList;
            });

            Connection.On("initFuncionario", (List<Model.Chat> chatList) =>
            {
                ChatList = chatList;
                IsChatMode = false;
                //layoutService.hideLoader();
            });

            Connection.On("connectToChat", (long selectedChatId) =>
            {
                SelectedChatId = selectedChatId;
            });

            Connection.On("chatNotFound", () =>
            {
                Console.WriteLine("Chat não encontrado");
            });

            Connection.On("isWriting", (string username, long userId, long chatId) =>
            {
                RenderIsWriting(username, userId, chatId);
            });

            Connection.On("previousMessages", (List<Model.Message> messages) =>
            {
                IsChatMode = true;
                GetChatSelected(SelectedChatId).MessagesList = messages;
                GetChatSelected(SelectedChatId).MessagesList.ForEach(message => {
                    //message.Timestamp = this.FormatDate(message.Timestamp)
                });
                GetChatSelected(SelectedChatId).MessagesList.Reverse();
                //layoutService.hideLoader();
            });

            Connection.StartAsync().ContinueWith((a) =>
            {
                GetUserInfo((long userId) => {
                    UserId = userId;
                    Connection.SendAsync("initFuncionario", userId);
                    Console.WriteLine("Chat conectado");
                    return true;
                });
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    public Model.Chat GetChatSelected(long chatId) {
        return ChatList.First(c => c.ChatId == chatId);
    }

    public void EnterChat(long chatId) {
        GetUserInfo((long userId) => {
            Connection.SendAsync("connectToChat", userId, chatId);
            return true;
        });
    }

    public void SairChat()
    {
        GetUserInfo((long userId) => {
            Connection.SendAsync("leaveSession", userId, SelectedChatId);
            IsChatMode = false;
            return true;
        });
    }

    public void EncerrarSessao()
    {
        Connection.SendAsync("closeSession", SelectedChatId);
    }

    public void GetUserInfo(Func<long, bool> callback)
    {
        long userId = 0;
        callback(userId);
    }

    public void SendMessage()
    {
        GetUserInfo((long userId) => {
            string username = "teste";
            string text = "";
            if (text != "" && text != null)
            {

                var newMessage = new Model.Message()
                {
                    OwnerId = userId,
                    Text = text,
                    Username = username,
                    Type = "Message"
                };

                Connection.SendAsync("newMessage", newMessage, SelectedChatId).ContinueWith((a) =>
                {
                    // this.messageForm.reset();
                });
            }
            return true;
        });
    }

    public void IsWritingNotifyAll()
    {
        //var typing = false;
        //GetUserInfo((username: string, userId: number) => {
        //    if (typing === false)
        //    {
        //        this.delay(() => {
        //            this.connection.send("isWriting", "", userId, this.selectedChatId)
        //          typing = false;
        //        }, this.typingDelayMillis);
        //        typing = true;
        //        this.connection.send("isWriting", username, userId, this.selectedChatId)
        //    }
        //})
    }

    public void RenderMessageOnChat(Model.Message message, long chatId)
    {
        //message.timestamp = this.formatDate(message.timestamp);
        GetChatSelected(chatId).MessagesList.Insert(0, message);
    }

    public void RenderIsWriting(string username, long userId, long chatId)
    {
        //var isWritingElement = document.getElementById("isWriting");
        //if (username != "" && userId != this.userId && chatId == this.selectedChatId)
        //{
        //    if (isWritingElement)
        //        document.getElementById("isWriting").classList.add("animate")
        //  this.isWriting.next(username + " está digitando");
        //}
        //else if (userId != this.userId)
        //{
        //    if (isWritingElement)
        //        document.getElementById("isWriting").classList.remove("animate")
        //}
    }

    public void CloseSession()
    {
        //this.messageService.popupInfo("Você encerrou a sessão com o cliente.", () => {
            IsChatMode = false;
            Connection.SendAsync("updateChatList");
            Connection.SendAsync("startedChats", UserId);
        //}, "")
    }

    public void VoltarPraLista()
    {
        IsChatMode = false;
        Connection.SendAsync("updateChatList");
        Connection.SendAsync("startedChats", UserId);
    }
}
