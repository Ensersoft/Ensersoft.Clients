using System.ComponentModel.DataAnnotations;

namespace Ensersoft.Clients.Options;

public class PredictorClientOptions : InternalClientOptionsBase
{
    [Required]
    public int Timeout { get; set; }
}
