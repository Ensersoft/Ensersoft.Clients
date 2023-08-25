namespace Ensersoft.Clients.Abstractions.Predictor.Common;

public class Prediction
{
    public DateOnly Date { get; init; }
    public ICollection<double> Probabilities { get; init; }

    public Prediction(DateOnly date, ICollection<double> probabilities)
    {
        Date = date;
        Probabilities = probabilities;
    }
}
