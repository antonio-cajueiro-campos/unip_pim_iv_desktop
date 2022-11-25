using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models
{
    public class ApoliceCliente
    {
        [JsonPropertyName("vigencia")]
        public DateTime Vigencia { get; set; }

        [JsonPropertyName("emissao")]
        public DateTime Emissao { get; set; }

        [JsonPropertyName("sinistros")]
        public IDictionary<string, decimal> Sinistros { get; set; }

        [JsonPropertyName("valorCobertura")]
        public decimal ValorCobertura { get; set; }

    }
}
