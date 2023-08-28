using Ensersoft.Clients.Common.Base;
using Ensersoft.Clients.Common;

namespace Ensersoft.Clients.Predictions;

public class PredictionsClientBase : InternalApiClientBase
{
    protected override string HttpClientKey => InternalApiClients.PredictionsClient;

    public PredictionsClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }
}
