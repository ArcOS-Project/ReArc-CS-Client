using System.Net.Http.Headers;

namespace ReArc.ApiHandler;

public static class HttpClientExtensions
{
    public static HttpClient AddTokenToHeader(this HttpClient cl, string? token)
    {
        string contentType = "application/json";

        if (token == null)
        {
            cl.DefaultRequestHeaders.Remove("Authorization");
        }
        else
        {
            cl.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", token));
        }

        cl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

        return cl;
    }
}