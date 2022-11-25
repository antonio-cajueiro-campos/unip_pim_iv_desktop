using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class Authenticate
{
    [JsonPropertyName("jwt")]
    public JwtEntity Jwt { get; set; }
}
