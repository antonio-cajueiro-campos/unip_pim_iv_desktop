using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class GetUserInfos
{
    [JsonPropertyName("user")]
    public UserDTO User { get; set; }

    [JsonPropertyName("endereco")]
    public EnderecoDTO Endereco { get; set; }

    [JsonPropertyName("telefone")]
    public string Telefone { get; set; }

    [JsonPropertyName("chavePIX")]
    public string ChavePIX { get; set; }

    [JsonPropertyName("cargo")]
    public string Cargo { get; set; }
}
