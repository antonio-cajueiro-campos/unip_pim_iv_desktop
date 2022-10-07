namespace unip_pim_iv_desktop.Models;

internal class Message
{
    public long OwnerId { get; set; }
    public string? Username { get; set; }
    public string? Text { get; set; }
    public string? Type { get; set; }
    public DateTime Timestamp { get; set; }
}
