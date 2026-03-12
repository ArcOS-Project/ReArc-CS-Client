using ReArc.ApiHandler.Extensions;
using ReArc.Shared;
using ReArc.Shared.Records.Configuration;
using ReArc.Shared.Records.Responses;
using System.Net;
using System.Net.Http.Json;
using System.Web;

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
    public bool Connected { get; private set; }
    public static bool ClientIsConnected
    {
        get => _currentClient?.Connected ?? false;
    }
    public static string? Hostname
    {
        get => _currentClient?.Connected == true ? new Uri(_currentClient?.ServerOption.Url!).Host : null;
    }

    private ServerInfo? _serverInfo = null;
    public ServerInfo? ServerInfo => _serverInfo;
    public ServerOption ServerOption { get; private set; }
    private readonly HttpClient client;

    #region Initialization

    public Client(ServerOption serverOption)
    {
        if (_currentClient != null) throw new Exception("A client has already been initialized. Dispose the client before creating a new one.");

        CurrentClient = this;
        ServerOption = serverOption;
        client = new()
        {
            BaseAddress = new Uri(ServerOption.Url),
            Timeout = TimeSpan.FromSeconds(8)
        };
    }

    public static async Task<CommandResult<Client>> Initialize(ServerOption serverOption)
    {
        var validation = ValidateServerUrl(serverOption.Url);
        if (!validation.Success) return CommandResult<Client>.Error(validation.ErrorMessage);

        try
        {
            var client = new Client(serverOption);
            var pingResult = await client.Ping();

            if (!pingResult.Success)
            {
                return CommandResult<Client>.Error(pingResult.ErrorMessage);
            }

            return CommandResult<Client>.Ok(client);
        }
        catch (Exception e)
        {
            return CommandResult<Client>.Error(e.Message);
        }

    }

    public static void Dispose()
    {
        _currentClient?.Connected = false;
        _currentClient = null;
    }

    #endregion

    #region HTTP Methods

    public async Task<CommandResult<ServerInfo>> Ping()
    {
        var ct = new CancellationTokenSource();
        ct.CancelAfter(3000);

        try
        {
            Connected = false;
            var response = await client.GetFromJsonAsync<ServerInfo>(CreateUrl("/ping"), ct.Token);
            if (response is null) return CommandResult<ServerInfo>.Error("Failed to connect to server");

            _serverInfo = response;
            Connected = true;
            return CommandResult<ServerInfo>.Ok(_serverInfo);
        }
        catch (Exception e)
        {
            if (ct.IsCancellationRequested)
            {
                return CommandResult<ServerInfo>.Error("Connection timed out");
            }
            else
            {
                return CommandResult<ServerInfo>.Error(e.Message);
            }
        }
    }

    public async Task<CommandResult<HttpResponseMessage>> Post(string route, Dictionary<string, string> bodyParams, Dictionary<string, string>? parameters = null)
    {
        try
        {
            var content = new MultipartFormDataContent();
            foreach (string key in bodyParams.Keys)
            {
                string value = bodyParams[key];

                content.Add(new StringContent(value), key);
            }

            var response = await client.PostAsync(CreateUrl(route, parameters), content);
            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }

    public async Task<CommandResult<HttpResponseMessage>> Post(string route, string token)
    {
        try
        {
            var response = await client.WithToken(token).PostAsync(CreateUrl(route), null);
            client.WithToken(null);

            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }

    public async Task<CommandResult<HttpResponseMessage>> Post(string route, string token, Dictionary<string, string> bodyParams)
    {
        try
        {
            var content = new MultipartFormDataContent();
            foreach (string key in bodyParams.Keys)
            {
                string value = bodyParams[key];

                content.Add(new StringContent(value), key);
            }

            var response = await client.WithToken(token).PostAsync(CreateUrl(route), content);
            client.WithToken(null);

            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }


    public async Task<CommandResult<T>> PostForJson<T>(string route, Dictionary<string, string> bodyParams, Dictionary<string, string>? parameters = null)
    {
        var response = await Post(route, bodyParams, parameters);
        if (!response.Success)
        {
            return CommandResult<T>.Error(response.ErrorMessage);
        }

        return await NormalizeJsonResponse<T>(response.Result!);
    }

    public async Task<CommandResult<T>> PostForJson<T>(string route, string token)
    {
        var response = await Post(route, token);
        client.WithToken(null);

        if (!response.Success)
        {
            return CommandResult<T>.Error(response.ErrorMessage);
        }

        return await NormalizeJsonResponse<T>(response.Result!);
    }

    public async Task<CommandResult<T>> GetJson<T>(string route, string? token = null, Dictionary<string, string>? parameters = null)
    {
        try
        {
            var response = token != null
                ? await client.WithToken(token).GetAsync(CreateUrl(route, parameters))
                : await client.GetAsync(CreateUrl(route, parameters));

            client.WithToken(null);

            return await NormalizeJsonResponse<T>(response);
        }
        catch (Exception e)
        {
            return CommandResult<T>.Error(e.Message);
        }
    }


    public async Task<CommandResult<HttpResponseMessage>> Get(string route, Dictionary<string, string>? parameters = null)
    {
        try
        {
            var response = await client.GetAsync(CreateUrl(route, parameters));
            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }

    public async Task<CommandResult<HttpResponseMessage>> Get(string route, string token)
    {
        try
        {
            var response = await client.WithToken(token).GetAsync(CreateUrl(route));
            client.WithToken(null);
            
            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }


    public async Task<CommandResult<HttpResponseMessage>> Delete(string route, string? token = null, Dictionary<string, string>? parameters = null)
    {
        try
        {
            var response = token != null
                ? await client.WithToken(token).DeleteAsync(CreateUrl(route, parameters))
                : await client.DeleteAsync(route);
            
            client.WithToken(null);

            if (response.StatusCode != HttpStatusCode.OK)
                return await HandleNotOkResponse<HttpResponseMessage>(response);

            return CommandResult<HttpResponseMessage>.Ok(response);
        }
        catch (Exception e)
        {
            return CommandResult<HttpResponseMessage>.Error(e.Message);
        }
    }

    #endregion

    #region Utilities

    public static ServerOption CreateServerOption(string hostname, int port, string? authCode)
    {
        UriBuilder uri = new()
        {
            Host = hostname,
            Scheme = port == 443 ? "https" : "http"
        };

        if (port != 80 && port != 443) uri.Port = port;

        return new ServerOption()
        {
            Url = uri.ToString(),
            AuthCode = authCode
        };
    }

    private static async Task<CommandResult<T>> NormalizeJsonResponse<T>(HttpResponseMessage response)
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

    private static async Task<CommandResult<T>> HandleNotOkResponse<T>(HttpResponseMessage response)
    {
        try
        {
            var responseJson = (await response.Content.ReadFromJsonAsync<ErrorResponse>()) ?? throw new Exception();

            return CommandResult<T>.Error(responseJson.E);
        }
        catch (Exception)
        {
            return CommandResult<T>.Error("An error occurred, but the server didn't say what happened.");
        }
    }

    public string CreateUrl(string url, Dictionary<string, string>? parameters = null)
    {
        var query = HttpUtility.ParseQueryString(ServerOption.AuthCode != null ? $"authcode={ServerOption.AuthCode}" : string.Empty);

        if (parameters != null)
        {
            foreach (string key in parameters.Keys)
            {
                query.Set(key, parameters[key]);
            }
        }

        var queryString = query?.ToString() ?? "";
        var uriBuilder = new UriBuilder(ServerOption.Url!)
        {
            Path = url,
            Query = queryString
        };
        return uriBuilder.ToString();
    }

    public static CommandResult<string> ValidateServerUrl(string url)
    {
        var builder = new UriBuilder(url);

        if (builder.Path != "/") return CommandResult<string>.Error("Server URLs may not have a path");
        if (builder.Scheme == "https" && builder.Port != 443) return CommandResult<string>.Error("HTTPS on an irregular port is not allowed.");

        return CommandResult<string>.Ok(url);
    }

    #endregion
}
