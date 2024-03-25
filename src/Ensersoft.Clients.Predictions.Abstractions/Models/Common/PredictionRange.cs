namespace Ensersoft.Clients.Predictions.Abstractions.Models.Common;

public class PredictionRange
{
    public int RegionKey { get; set; }
    public DateOnly FirstPredictionDay { get; set; }
    public DateOnly LastPredictionDay { get; set; }
}
