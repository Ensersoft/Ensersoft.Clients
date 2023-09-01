using System.ComponentModel.DataAnnotations;

namespace Ensersoft.Clients.Common.Options;

public class ApiKeyOptions
{
    [Required]
    public string ApiKey { get; set; } = default!;
    public string ApiKeyHeader { get; set; } = default!;
}
