namespace Ensersoft.Clients.WebApi.Abstractions.Models;

public record GetPredictorRegionsRequest
{
    public long? RegionId { get; set; }
    public int? RegionKey { get; set; }

    public GetPredictorRegionsRequest(long? regionId, int? regionKey)
    {
        RegionKey = regionKey;
        RegionId = regionId;
    }
}