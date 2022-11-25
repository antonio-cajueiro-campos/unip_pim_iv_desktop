using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Login_e_Registro_Sistema.Models;

public class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("document")]
    public string Document { get; set; }

    [JsonPropertyName("registrationDate")]
    public DateTime RegistrationDate { get; set; }
}