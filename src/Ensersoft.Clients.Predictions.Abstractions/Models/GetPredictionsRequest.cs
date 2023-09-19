namespace Ensersoft.Clients.Predictions.Abstractions.Models;

public record GetPredictionsRequest
{
    public int RegionKey { get; set; }
    public DateOnly FromDate { get; set; }
    public DateOnly ToDate { get; set; }

    public GetPredictionsRequest(int regionKey, DateOnly fromDate, DateOnly toDate)
    {
        RegionKey = regionKey;
        FromDate = fromDate;
        ToDate = toDate;
    }
}