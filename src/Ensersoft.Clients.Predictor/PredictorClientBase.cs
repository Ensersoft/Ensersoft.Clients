using Ensersoft.Clients.Common.Base;
using Ensersoft.Clients.Common;

namespace Ensersoft.Clients.Predictor;

public class PredictorClientBase : InternalApiClientBase
{
    protected override string HttpClientKey => InternalApiClients.PredictorClient;

    public PredictorClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }
}
