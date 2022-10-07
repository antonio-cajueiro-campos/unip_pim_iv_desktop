using Microsoft.AspNetCore.SignalR.Client;
using unip_pim_iv_desktop.Models;

namespace unip_pim_iv_desktop;
internal class ChatService
{

    public static HubConnection connection;

    public ChatService()
    {
        connection = new HubConnectionBuilder()
            .WithUrl("")
            .Build();
    }

    public static void StartConnection()
    {
        connection.On("newMessage", (Message message, long chatId) => {
            //renderMessageOnChat(message, chatId)
        });

        connection.On("closeSession", () => {
            //closeSession();
        });

        connection.On("updateChatList", (Chat[] chatList) => {
            //chatList = chatList;
        });

        connection.On("startedChats", (Chat[] startedChatList) => {
            //startedChatList = startedChatList;
        });

        connection.On("initFuncionario", (Chat[] chatList) => {
            //chatList = chatList;
            //isChatMode = false;
            //layoutService.hideLoader();
        });

        connection.On("connectToChat", (long selectedChatId) => {
            //selectedChatId = selectedChatId;
        });

        connection.On("chatNotFound", () => {
            //console.log("Chat não encontrado");
        });

        connection.On("isWriting", (string username, long userId, long chatId) => {
            //renderIsWriting(username, userId, chatId);
        });

        connection.On("previousMessages", (List<Message> messages) => {
            //isChatMode = true;
            //getChatSelected(this.selectedChatId).messagesList = messages;
            //getChatSelected(this.selectedChatId).messagesList.forEach(message => {
            //    message.timestamp = this.formatDate(message.timestamp)
            //});
            //getChatSelected(this.selectedChatId).messagesList.reverse()
            //layoutService.hideLoader();
        });
    }
}
