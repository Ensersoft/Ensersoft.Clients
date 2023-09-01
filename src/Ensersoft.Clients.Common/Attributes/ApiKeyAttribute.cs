using Ensersoft.Clients.Common.Exceptions;
using Ensersoft.Clients.Common.Options;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Ensersoft.Clients.Common.Attributes;

[AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
public sealed class ApiKeyAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var appSettings = context.HttpContext.RequestServices.GetRequiredService<ApiKeyOptions>();
        var apiKey = appSettings.ApiKey;
        var apiKeyHeader = ApiKeyOptions.ApiKeyHeader;

        if (!context.HttpContext.Request.Headers.TryGetValue(apiKeyHeader, out var keyStr)
            || keyStr.Count == 0 || !apiKey.Equals(keyStr[0], StringComparison.Ordinal))
        {
            throw new InvalidApiKeyHeaderException();
        }

        await next();
    }
}