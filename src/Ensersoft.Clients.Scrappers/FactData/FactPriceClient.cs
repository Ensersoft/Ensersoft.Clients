using System.Net.Http.Json;
using Ensersoft.Clients.Scrappers.Abstractions.Models;
using Ensersoft.Clients.Scrappers.Abstractions;
using Microsoft.AspNetCore.Http.Extensions;
using System.Globalization;

namespace Ensersoft.Clients.Scrappers.FactData;

public class FactPriceClient : ScrappersClientBase, IFactPriceClient
{
    protected override string BaseAddress => $"{base.BaseAddress}FactPrice/";

    public FactPriceClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<GetFactPriceResponse> GetFactPrice(GetFactPriceRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new QueryBuilder
        {
            { "RegionKey", request.RegionKey.ToString(CultureInfo.InvariantCulture)},
            { "DateStart", request.FromDate.ToString(CultureInfo.InvariantCulture)},
            { "DateEnd", request.ToDate.ToString(CultureInfo.InvariantCulture) },
        };
        var uri = new Uri($"{BaseAddress}query{query}", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.GetAsync(uri, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetFactPriceResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }
}
