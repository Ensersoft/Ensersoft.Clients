using Ensersoft.Clients.Abstractions.Predictor.Common;
using Ensersoft.Clients.Abstractions.Predictor.Models;

namespace Ensersoft.Clients.Abstractions.Predictor;

public interface IPredictorClient
{
    Task SetupModel(SetupModelRequest request,
        CancellationToken cancellationToken = default);
    Task FitModel(FitModelRequest request,
        CancellationToken cancellationToken = default);
    Task<PredictionResult> Predict(PredictRequest request,
        CancellationToken cancellationToken = default);
}
