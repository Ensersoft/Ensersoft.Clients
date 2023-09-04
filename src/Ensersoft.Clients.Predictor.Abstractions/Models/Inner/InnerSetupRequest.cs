namespace Ensersoft.Clients.Predictor.Abstractions.Models.Inner;

public record InnerSetupRequest
{
    public int RegionKey { get; set; } = default!;
    public int FromYear { get; set; }
    public int FromMonth { get; set; }
    public int ToYear { get; set; }
    public int ToMonth { get; set; }

    public InnerSetupRequest(int regionKey, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        RegionKey = regionKey;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }

    public static InnerSetupRequest FromSetupModelRequest(SetupModelRequest setupRequest)
    {
        return new InnerSetupRequest(setupRequest.RegionKey,
         setupRequest.FromDate.Year, setupRequest.FromDate.Month, setupRequest.ToDate.Year, setupRequest.ToDate.Month);
    }
}
