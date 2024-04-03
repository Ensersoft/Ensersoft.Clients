using System.Net.Http.Json;
using Ensersoft.Clients.Scrappers.Abstractions.Models;
using Ensersoft.Clients.Scrappers.Abstractions;
using Microsoft.AspNetCore.Http.Extensions;
using System.Globalization;

namespace Ensersoft.Clients.Scrappers.FactData;

public class FactHoursClient : ScrappersClientBase, IFactHoursClient
{
    protected override string BaseAddress => $"{base.BaseAddress}FactHours/";

    public FactHoursClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<GetFactHoursResponse> GetFactHours(GetFactHoursRequest request,
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
        var result = await response.Content.ReadFromJsonAsync<GetFactHoursResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }

    public async Task<GetFactHoursRangesResponse> GetFactHoursRanges(GetFactHoursRangesRequest request, CancellationToken cancellationToken = default)
    {
        var uri = new Uri($"{BaseAddress}ranges", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetFactHoursRangesResponse>(cancellationToken: cancellationToken);
        return result!;
    }
}
