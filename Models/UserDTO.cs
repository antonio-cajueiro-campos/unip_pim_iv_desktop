using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Login_e_Registro_Sistema.Models;
public class UserDTO
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("document")]
    public string Document { get; set; }

    [JsonPropertyName("credential")]
    public CredentialDTO Credential { get; set; }

    [JsonPropertyName("registrationDate")]
    public DateTime RegistrationDate { get; set; }
}