using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using unip_pim_iv_desktop.Models;
using System.Net.Http.Headers;

namespace unip_pim_iv_desktop.Services;

internal class RequestService
{
    private readonly string BASE_URL = "https://tsb-portal.herokuapp.com";

    public async Task<DefaultResponse> GetAsync(string endpoint)
    {
        try
        {
            var response = new DefaultResponse();

            using var client = new HttpClient();
            var responseServer = await client.GetAsync($"{BASE_URL}{endpoint}");

            responseServer.EnsureSuccessStatusCode();

            var content = System.Text.Json.JsonSerializer.Deserialize<DefaultResponse>(await responseServer.Content.ReadAsStringAsync());
            if (content != null) return content;

            return response;
        }
        catch (HttpRequestException ex)
        {
            return new()
            {
                Status = ex.StatusCode,
                Error = true,
                Message = ex.Message,
                Data = ex.Data
            };
        }
    }

    public async Task<DefaultResponse> PostAsync(string endpoint, object value)
    {
        try
        {
            var body = UrlEncodeObject(value);

            var response = new DefaultResponse();

            using var client = new HttpClient();
            var responseServer = await client.PostAsync($"{BASE_URL}{endpoint}", body);

            responseServer.EnsureSuccessStatusCode();

            var content = System.Text.Json.JsonSerializer.Deserialize<DefaultResponse>(await responseServer.Content.ReadAsStringAsync());
            if (content != null) return content;

            return response;
        }
        catch (HttpRequestException ex)
        {

            return new()
            {
                Status = ex.StatusCode,
                Error = true,
                Message = ex.Message,
                Data = ex.Data
            };
        }
    }

    public HubConnection SignalR(long userId)
    {
        return new HubConnectionBuilder()
            .WithUrl($"{BASE_URL}/websocketchat?userId={userId}")
            .WithAutomaticReconnect()
            .ConfigureLogging(logging =>
            {
                logging.AddFilter("Microsoft.AspNetCore.SignalR", LogLevel.Warning);
                logging.AddFilter("Microsoft.AspNetCore.Http.Connections", LogLevel.Warning);
            })
            .Build();
    }

    private static ByteArrayContent UrlEncodeObject(object data)
    {
        var myContent = JsonConvert.SerializeObject(data);
        var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
        var byteContent = new ByteArrayContent(buffer);
        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        return byteContent;
    }
}
