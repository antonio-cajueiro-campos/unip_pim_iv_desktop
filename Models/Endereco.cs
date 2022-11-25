using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class Endereco
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cep")]
    public string Cep { get; set; }

    [JsonPropertyName("cidade")]
    public string Cidade { get; set; }

    [JsonPropertyName("estado")]
    public string Estado { get; set; }

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; }

    [JsonPropertyName("rua")]
    public string Rua { get; set; }

    [JsonPropertyName("numero")]
    public string Numero { get; set; }

    [JsonPropertyName("complemento")]
    public string Complemento { get; set; }
}
