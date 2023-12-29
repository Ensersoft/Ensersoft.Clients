using System.Net.Http.Json;
using Ensersoft.Clients.Scrappers.Abstractions.Models;
using Ensersoft.Clients.Scrappers.Abstractions;

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
        var uri = new Uri($"{BaseAddress}query", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetFactHoursResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }
}
