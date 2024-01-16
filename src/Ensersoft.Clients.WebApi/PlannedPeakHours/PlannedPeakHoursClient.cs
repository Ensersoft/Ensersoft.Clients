using System.Globalization;
using System.Net.Http.Json;
using Ensersoft.Clients.WebApi.Abstractions;
using Ensersoft.Clients.WebApi.Abstractions.Models;
using Microsoft.AspNetCore.Http.Extensions;

namespace Ensersoft.Clients.WebApi.PlannedPeakHours;

public class PlannedPeakHoursClient : WebApiClientBase, IPlannedPeakHoursClient
{
    protected override string BaseAddress => $"{base.BaseAddress}Regions/peakhours/";

    public PlannedPeakHoursClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    public async Task<GetPlannedPeakHoursResponse> GetPlannedPeakHours(GetPlannedPeakHoursRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new QueryBuilder
        {
            { "regionKey", request.RegionKey.ToString(CultureInfo.InvariantCulture)},
            { "year", request.Year.ToString(CultureInfo.InvariantCulture)},
            { "month", request.Month.ToString(CultureInfo.InvariantCulture) },
        };
        var uri = new Uri($"{BaseAddress}query{query}", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.GetAsync(uri, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetPlannedPeakHoursResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }
}
