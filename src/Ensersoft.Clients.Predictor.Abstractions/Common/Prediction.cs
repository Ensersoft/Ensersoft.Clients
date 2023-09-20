namespace Ensersoft.Clients.Predictor.Abstractions.Common;

public class Prediction
{
    public DateOnly Date { get; init; }
    public ICollection<double> Probabilities { get; init; }
    public ICollection<PredictionHour> BestHours { get; init; }

    public Prediction(DateOnly date, ICollection<double> probabilities, ICollection<PredictionHour> bestHours)
    {
        Date = date;
        Probabilities = probabilities;
        BestHours = bestHours;
    }
}
