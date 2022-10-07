namespace unip_pim_iv_desktop.Models;

internal class Chat
{
    public long ChatId { get; set; }
    public string? Type { get; set; }
    public List<UserHub> UserList { get; set; }
    public List<Message> MessagesList { get; set; }
}
