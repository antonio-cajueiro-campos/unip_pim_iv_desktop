using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;

public class ClienteOutput
{
    [JsonPropertyName("clientes")]
    public List<Cliente> Clientes { get; set; }
}
