namespace Ensersoft.Clients.Predictor.Abstractions.Common;

public class PredictionResult
{
    public ICollection<Prediction> Predictions { get; init; }

    public PredictionResult(ICollection<Prediction> predictions)
    {
        Predictions = predictions;
    }
}
