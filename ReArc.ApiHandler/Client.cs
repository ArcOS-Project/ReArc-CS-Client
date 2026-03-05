using ReArc.ApiHandler.Extensions;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;
using ReArc.Shared.Records.Responses;
using System.Net;
using System.Net.Http.Json;

namespace ReArc.ApiHandler;

public class Client
{
    private static Client? _currentClient;
    public static Client CurrentClient
    {
        get
        {
            if (_currentClient == null || !_currentClient.Connected) throw new Exception("No client has been intialized and connected yet.");

            return _currentClient;
        }
        set => _currentClient = value;
    }
    public bool Connected
    {
        get;
        private set => field = value;
    }
    private ServerInfo? _serverInfo = null;
    private ServerOption _serverOption;
    private readonly HttpClient client;

    public Client(ServerOption serverOption)
    {
        if (_currentClient != null) throw new Exception("A client has already been initialized. Dispose the client before creating a new one.");

        CurrentClient = this;
        _serverOption = serverOption;
        client = new()
        {
            BaseAddress = new Uri(_serverOption.Url),
        };
    }

    public static async Task<CommandResult<Client>> Initialize(ServerOption serverOption)
    {
        var client = new Client(serverOption);
        var pingResult = await client.Ping();

        if (!pingResult.Success)
        {
            return CommandResult<Client>.Error(pingResult.ErrorMessage ?? "Failed to connect to server");
        }

        return CommandResult<Client>.Ok(client);
    }

    public ServerInfo? ServerInfo => _serverInfo;

    public async Task<CommandResult<ServerInfo>> Ping()
    {
        Connected = false;
        var response = await client.GetFromJsonAsync<ServerInfo>("/ping");
        if (response is null) return CommandResult<ServerInfo>.Error("Failed to connect to server");

        _serverInfo = response;
        Connected = true;
        return CommandResult<ServerInfo>.Ok(_serverInfo);
    }

    public async Task<CommandResult<HttpResponseMessage>> Post(string route, Dictionary<string, string> bodyParams)
    {
        try
        {
            var content = new MultipartFormDataContent();
            foreach (string key in bodyParams.Keys)
            {
                string value = bodyParams[key];

                content.Add(new StringContent(value), key);
            }

            var response = await client.PostAsync(route, content);
            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }

    public async Task<CommandResult<T>> PostForJson<T>(string route, Dictionary<string, string> bodyParams)
    {
        var response = await Post("/login", bodyParams);

        if (!response.Success)
        {
            return CommandResult<T>.Error(response.ErrorMessage ?? "Unknown error");
        }

        return await NormalizeJsonResponse<T>(response.Result!);
    }

    public async Task<CommandResult<T>> GetJson<T>(string route, string? token = null)
    {
        try
        {
            var response = token != null ? await client.WithToken(token).GetAsync(route) : await client.GetAsync(route);
            return await NormalizeJsonResponse<T>(response);
        }
        catch (Exception e)
        {
            return CommandResult<T>.Error(e.Message);
        }
    }

    private async Task<CommandResult<T>> NormalizeJsonResponse<T>(HttpResponseMessage response)
    {
        try
        {
            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<T>(response);

            var responseJson = await response.Content.ReadFromJsonAsync<T>();
            if (responseJson == null) return CommandResult<T>.Error("Couldn't understand response from server");

            return CommandResult<T>.Ok(responseJson);
        }
        catch (Exception e)
        {
            return CommandResult<T>.Error(e.Message);
        }
    }

    private async Task<CommandResult<T>> HandleNotOkResponse<T>(HttpResponseMessage response)
    {
        try
        {
            var responseJson = await response.Content.ReadFromJsonAsync<ErrorResponse>();
            if (responseJson == null) return CommandResult<T>.Error("An error occurred, but the server didn't say what happened.");

            return CommandResult<T>.Error(responseJson.E ?? "Unknown error");
        }
        catch (Exception e)
        {
            return CommandResult<T>.Error(e.Message);
        }
    }

    public async Task<CommandResult<HttpResponseMessage>> Delete(string route, string? token = null)
    {
        try
        {
            var response = token != null ? await client.WithToken(token).DeleteAsync(route) : await client.DeleteAsync(route);
            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }
}
