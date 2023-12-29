using Ensersoft.Clients.Scrappers.Abstractions.Models;

namespace Ensersoft.Clients.Scrappers.Abstractions;

public interface IFactPriceClient
{
    Task<GetFactPriceResponse> GetFactPrice(GetFactPriceRequest request,
        CancellationToken cancellationToken = default);
}
