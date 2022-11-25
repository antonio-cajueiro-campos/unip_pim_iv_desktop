using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class JwtEntity {

    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("refreshToken")]
    public string RefreshToken { get; set; }

    [JsonPropertyName("expirationTime")]
    public DateTime? ExpirationTime { get; set; }
}
