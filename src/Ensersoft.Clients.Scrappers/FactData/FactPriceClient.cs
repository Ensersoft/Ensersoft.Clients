using System.Net.Http.Json;
using Ensersoft.Clients.Scrappers.Abstractions.Models;
using Ensersoft.Clients.Scrappers.Abstractions;

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
        var uri = new Uri($"{BaseAddress}query", UriKind.Relative);
        var response = await SendRequestAndValidate(() => HttpClient.PostAsJsonAsync(uri, request, cancellationToken));
        var result = await response.Content.ReadFromJsonAsync<GetFactPriceResponse>(cancellationToken: CancellationToken.None);
        return result!;
    }
}
