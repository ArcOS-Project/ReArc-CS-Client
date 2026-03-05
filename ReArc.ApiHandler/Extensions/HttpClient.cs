using System.Net.Http.Headers;

namespace ReArc.ApiHandler.Extensions;

public static class HttpClientExtensions
{
    public static HttpClient WithToken(this HttpClient cl, string? token)
    {
        string contentType = "application/json";
        cl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
        cl.DefaultRequestHeaders.Remove("Authorization");

        if (token != null) cl.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token));

        return cl;
    }
}