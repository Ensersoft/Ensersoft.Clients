using Ensersoft.Clients.Common.Base;
using Ensersoft.Clients.Common;

namespace Ensersoft.Clients.Scrappers;

public class ScrappersClientBase : InternalApiClientBase
{
    protected override string HttpClientKey => InternalApiClients.ScrappersClient;

    public ScrappersClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }
}
