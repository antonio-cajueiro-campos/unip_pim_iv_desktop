namespace unip_pim_iv_desktop.Models;

internal class Chat
{
    public long ChatId { get; set; }
    public string Type { get; set; }
    public UserHub[] UserList { get; set; }
    public Message[] MessagesList { get; set; }
}
