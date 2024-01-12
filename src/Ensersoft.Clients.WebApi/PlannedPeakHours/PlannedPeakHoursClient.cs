using System.Net.Http.Json;
using Ensersoft.Clients.WebApi.Abstractions;
using Ensersoft.Clients.WebApi.Abstractions.Models;

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
        var uri = new Uri($"{BaseAddress}query", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetPlannedPeakHoursResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }
}
