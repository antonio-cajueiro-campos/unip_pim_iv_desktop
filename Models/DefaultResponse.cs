using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class DefaultResponse<T>
{
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("error")]
    public bool Error { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("data")]
    public T? Data { get; set; }
}
