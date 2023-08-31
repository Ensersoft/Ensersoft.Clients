using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ensersoft.Clients.Common.Attributes;

[AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]
public sealed class ApiKeyAttribute : Attribute, IAsyncActionFilter
{
    private const string APIKEY_HEADER = "ApiKey";
    private const string APIKEY_SETTING = "ApiKey";

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey(APIKEY_HEADER))
        {
            context.Result = new ContentResult()
            {
                StatusCode = 401,
                Content = "You need to provide a valid ApiKey"
            };
            return;
        }

        context.HttpContext.Request.Headers.TryGetValue(APIKEY_HEADER, out var keyStr);

        if (keyStr.Count == 0)
        {
            context.Result = new ContentResult()
            {
                StatusCode = 401,
                Content = "You need to provide a valid ApiKey"
            };
            return;
        }

        var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
        var apiKey = appSettings.GetValue<string>(APIKEY_SETTING);

        if (apiKey == null || !apiKey.Equals(keyStr[0], StringComparison.Ordinal))
        {
            context.Result = new ContentResult()
            {
                StatusCode = 401,
                Content = "You need to provide a valid ApiKey"
            };
            return;
        }

        await next();
    }
}