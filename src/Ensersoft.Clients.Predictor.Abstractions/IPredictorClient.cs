using Ensersoft.Clients.Predictor.Abstractions.Common;
using Ensersoft.Clients.Predictor.Abstractions.Models;

namespace Ensersoft.Clients.Predictor.Abstractions;

public interface IPredictorClient
{
    Task SetupModel(SetupModelRequest request,
        CancellationToken cancellationToken = default);
    Task FitModel(FitModelRequest request,
        CancellationToken cancellationToken = default);
    Task<PredictionResult> Predict(PredictRequest request,
        CancellationToken cancellationToken = default);
}
