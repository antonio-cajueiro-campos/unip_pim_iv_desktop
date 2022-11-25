using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class Cliente
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("user")]
    public User? User { get; set; }

    [JsonPropertyName("endereco")]
    public Endereco? Endereco { get; set; }

    [JsonPropertyName("telefone")]
    public string Telefone { get; set; }

    [JsonPropertyName("chavePIX")]
    public string ChavePIX { get; set; }
}
