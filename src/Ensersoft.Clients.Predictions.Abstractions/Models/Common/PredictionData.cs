namespace Ensersoft.Clients.Predictions.Abstractions.Models.Common;

public record PredictionData
{
    public int RegionKey { get; set; }
    public DateOnly Date { get; set; }
    public double[] Probabilities { get; set; } = default!;
}