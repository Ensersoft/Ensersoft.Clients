namespace Ensersoft.Clients.Base;

public abstract class HttpClientBase
{
    protected HttpClient HttpClient { get; }

    protected abstract string HttpClientKey { get; }

    protected HttpClientBase(IHttpClientFactory httpClientFactory)
    {
        HttpClient = httpClientFactory.CreateClient(HttpClientKey);
    }
}
