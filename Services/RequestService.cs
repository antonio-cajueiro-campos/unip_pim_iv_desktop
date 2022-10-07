using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using unip_pim_iv_desktop.Models;

namespace unip_pim_iv_desktop.Services;

internal class RequestService
{
    private readonly string BASE_URL = "https://tsb-portal.herokuapp.com";

    public async Task<DefaultResponse> GetAsync()
    {
        try
        {
            var response = new DefaultResponse();

            using var client = new HttpClient();
            var responseServer = await client.GetAsync($"{BASE_URL}");

            responseServer.EnsureSuccessStatusCode();

            var content = JsonSerializer.Deserialize<DefaultResponse>(await responseServer.Content.ReadAsStringAsync());
            if (content != null) return content;

            return response;
        }
        catch (Exception ex)
        {
            return new DefaultResponse()
            {
                Status = 500,
                Error = true,
                Message = ex.Message,
                Data = null
            };
        }
    }

    public async Task<DefaultResponse> PostAsync(Dictionary<string, string> values)
    {
        try
        {
            var body = new FormUrlEncodedContent(values);

            var response = new DefaultResponse();

            using var client = new HttpClient();
            var responseServer = await client.PostAsync($"{BASE_URL}", body);

            responseServer.EnsureSuccessStatusCode();

            var content = JsonSerializer.Deserialize<DefaultResponse>(await responseServer.Content.ReadAsStringAsync());
            if (content != null) return content;

            return response;
        }
        catch (Exception ex)
        {
            return new DefaultResponse()
            {
                Status = 500,
                Error = true,
                Message = ex.Message,
                Data = null
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
}
