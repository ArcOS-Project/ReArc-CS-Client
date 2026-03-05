using System.Net.Http.Headers;

namespace ReArc.ApiHandler.Extensions;

public static class HttpClientExtensions
{
    public static HttpClient AddTokenToHeader(this HttpClient cl, string? token)
    {
        string contentType = "application/json";
        cl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

        if (token == null) cl.DefaultRequestHeaders.Remove("Authorization");
        else cl.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token));

        return cl;
    }
}