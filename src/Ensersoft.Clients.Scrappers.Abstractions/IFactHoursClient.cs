using Ensersoft.Clients.Scrappers.Abstractions.Models;

namespace Ensersoft.Clients.Scrappers.Abstractions;

public interface IFactHoursClient
{
    Task<GetFactHoursResponse> GetFactHours(GetFactHoursRequest request,
        CancellationToken cancellationToken = default);

    Task<GetFactHoursRangesResponse> GetFactHoursRanges(GetFactHoursRangesRequest request,
        CancellationToken cancellationToken = default);
}
