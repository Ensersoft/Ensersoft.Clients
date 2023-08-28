using System.ComponentModel.DataAnnotations;

namespace Ensersoft.Clients.Common.Options;

public abstract class InternalClientOptionsBase
{
    [Required]
    public string Url { get; set; } = default!;

    [Required]
    public string ApiKey { get; set; } = default!;
}
