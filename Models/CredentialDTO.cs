using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;
public class CredentialDTO
{
    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
}