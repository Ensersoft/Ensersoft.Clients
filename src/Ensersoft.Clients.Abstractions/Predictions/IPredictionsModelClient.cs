using Ensersoft.Clients.Abstractions.Predictions.Models;

namespace Ensersoft.Clients.Abstractions.Predictions;

public interface IPredictionsModelClient
{
    Task SetupModel(SetupModelRequest request,
        CancellationToken cancellationToken = default);
    Task FitModel(FitModelRequest request,
        CancellationToken cancellationToken = default);
    Task Predict(PredictRequest request,
        CancellationToken cancellationToken = default);
}
