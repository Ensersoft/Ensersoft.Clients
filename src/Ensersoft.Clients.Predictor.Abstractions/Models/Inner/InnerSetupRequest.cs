namespace Ensersoft.Clients.Predictor.Abstractions.Models.Inner;

public record InnerSetupRequest
{
    public string Region { get; set; } = default!;
    public int FromYear { get; set; }
    public int FromMonth { get; set; }
    public int ToYear { get; set; }
    public int ToMonth { get; set; }

    public InnerSetupRequest(string region, int fromYear, int fromMonth, int toYear, int toMonth)
    {
        Region = region;
        FromYear = fromYear;
        FromMonth = fromMonth;
        ToYear = toYear;
        ToMonth = toMonth;
    }

    public static InnerSetupRequest FromSetupModelRequest(SetupModelRequest setupRequest)
    {
        return new InnerSetupRequest(setupRequest.Region,
         setupRequest.FromDate.Year, setupRequest.FromDate.Month, setupRequest.ToDate.Year, setupRequest.ToDate.Month);
    }
}
