using System.Globalization;
using System.Net.Http.Json;
using Ensersoft.Clients.WebApi.Abstractions;
using Ensersoft.Clients.WebApi.Abstractions.Models;
using Microsoft.AspNetCore.Http.Extensions;

namespace Ensersoft.Clients.WebApi.PredictorRegions;

public class PredictorRegionsClient : WebApiClientBase, IPredictorRegionsClient
{
    protected override string BaseAddress => $"{base.BaseAddress}Regions/predictor/";

    public PredictorRegionsClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<GetPredictorRegionsResponse> GetPredictorRegions(GetPredictorRegionsRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new QueryBuilder
        {
        };
        if (request.RegionKey != null)
        {
            query.Add("regionKey", request.RegionKey.Value.ToString(CultureInfo.InvariantCulture));
        }
        if (request.RegionId != null)
        {
            query.Add("regionId", request.RegionId.Value.ToString(CultureInfo.InvariantCulture));
        }
        var uri = new Uri($"{BaseAddress}query{query}", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.GetAsync(uri, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetPredictorRegionsResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }
}
