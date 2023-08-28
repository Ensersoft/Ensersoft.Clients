using System.Net.Http.Json;
using Ensersoft.Clients.Common.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Ensersoft.Clients.Common.Base;

public abstract class InternalApiClientBase : HttpClientBase
{
    protected virtual string BaseAddress => "/internal-api/v1/";

    protected InternalApiClientBase(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
    {
    }

    protected static async Task<HttpResponseMessage> SendRequestAndValidate(Func<Task<HttpResponseMessage>> request)
    {
        var response = await request();
        if (!response.IsSuccessStatusCode)
        {
            try
            {
                await HandleProblemDetailsResponse(response);
            }
            catch (Exception e) when (e is not ProblemDetailsResponseException)
            {
                await HandleUnknownResponse(response);
            }
        }
        return response;
    }

    private static async Task HandleProblemDetailsResponse(HttpResponseMessage response)
    {
        var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>();

        if (problemDetails?.Status == (int)response.StatusCode)
        {
            throw new ProblemDetailsResponseException(problemDetails);
        }
        else
        {
            response.EnsureSuccessStatusCode();
        }
    }

    private static async Task HandleUnknownResponse(HttpResponseMessage response)
    {
        string? content = null;

        try
        {
            content = await response.Content.ReadAsStringAsync();
        }
        catch { }

        throw new InternalRequestException(response.StatusCode, content);
    }
}
