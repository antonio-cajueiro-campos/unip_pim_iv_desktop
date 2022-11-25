using Login_e_Registro_Sistema.Models;
using Login_e_Registro_Sistema.Services.Interfaces;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Login_e_Registro_Sistema.Services;

public class RequestService : IRequestServices
{
    private readonly string BASE_URL = "https://tsb-portal.herokuapp.com";

    public async Task<DefaultResponse<T>> GetAsync<T>(string endpoint)
    {
        try
        {
            using var client = new HttpClient();
            var responseServer = await client.GetAsync($"{BASE_URL}{endpoint}");

            responseServer.EnsureSuccessStatusCode();

            var stringContent = await responseServer.Content.ReadAsStringAsync();

            var content = JsonSerializer.Deserialize<DefaultResponse<T>>(stringContent);

            return content ?? new DefaultResponse<T>();
        }
        catch (HttpRequestException ex)
        {
            return new()
            {
                Status = 400,
                Error = true,
                Message = ex.Message
            };
        }
    }

    public async Task<DefaultResponse<T>> PostAsync<T>(string endpoint, object value)
    {
        try
        {
            var body = UrlEncodeObject(value);
            var json = true ? JsonSerializer.Serialize(value) : value.ToString();

            var requestData = new StringContent(json ?? string.Empty, Encoding.UTF8, "application/json");

            using var client = new HttpClient();
            var responseServer = await client.PostAsync($"{BASE_URL}{endpoint}", requestData);

            responseServer.EnsureSuccessStatusCode();

            var stringContent = await responseServer.Content.ReadAsStringAsync();

            var content = JsonSerializer.Deserialize<DefaultResponse<T>>(stringContent);

            return content ?? new DefaultResponse<T>();
        }
        catch (HttpRequestException ex)
        {

            return new()
            {
                Status = 400,
                Error = true,
                Message = ex.Message
            };
        }
    }

    private static ByteArrayContent UrlEncodeObject(object data)
    {
        var myContent = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
        var byteContent = new ByteArrayContent(buffer);
        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        return byteContent;
    }
}
