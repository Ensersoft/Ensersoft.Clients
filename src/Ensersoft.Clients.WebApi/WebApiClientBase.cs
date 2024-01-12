using Ensersoft.Clients.Common.Base;
using Ensersoft.Clients.Common;

namespace Ensersoft.Clients.WebApi;

public class WebApiClientBase : InternalApiClientBase
{
    protected override string HttpClientKey => InternalApiClients.WebApiClient;

    public WebApiClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }
}
