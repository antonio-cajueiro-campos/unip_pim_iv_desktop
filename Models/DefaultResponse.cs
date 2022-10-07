using System.Net;

namespace unip_pim_iv_desktop.Models;

internal class DefaultResponse
{
    public HttpStatusCode? Status { get; set; }
    public bool Error { get; set; }
    public string? Message { get; set; }
    public object? Data { get; set; }
}
