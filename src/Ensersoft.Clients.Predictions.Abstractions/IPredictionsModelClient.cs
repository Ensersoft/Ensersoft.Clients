using Ensersoft.Clients.Predictions.Abstractions.Models;

namespace Ensersoft.Clients.Predictions.Abstractions;

public interface IPredictionsModelClient
{
    Task SetupModel(SetupModelRequest request,
        CancellationToken cancellationToken = default);
    Task FitModel(FitModelRequest request,
        CancellationToken cancellationToken = default);
    Task Predict(PredictRequest request,
        CancellationToken cancellationToken = default);
}
