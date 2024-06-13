namespace Ensersoft.Clients.WebApi.Abstractions.Models.Common;

public record PredictorRegionData
{
    public PredictorRegionData(long regionId, int regionKey, string atsEnergoCode, string atsEnergoTitle)
    {
        RegionId = regionId;
        RegionKey = regionKey;
        AtsEnergoCode = atsEnergoCode;
        AtsEnergoTitle = atsEnergoTitle;
    }

    public long RegionId { get; init; }
    public int RegionKey { get; init; }
    public string AtsEnergoCode { get; init; } = default!;
    public string AtsEnergoTitle { get; init; } = default!;
}
