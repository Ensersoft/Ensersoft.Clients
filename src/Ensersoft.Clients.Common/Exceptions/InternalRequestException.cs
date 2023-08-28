using System.Net;

namespace Ensersoft.Clients.Common.Exceptions;

public class InternalRequestException : Exception
{
    public string? Content { get; }
    public HttpStatusCode StatusCode { get; }

    public override string Message => $"Received unexpected response. StatusCode = {StatusCode}; Content = {Content}";

    public InternalRequestException(HttpStatusCode statusCode, string? content)
    {
        StatusCode = statusCode;
        Content = content;
    }

    public InternalRequestException()
    {
    }

    public InternalRequestException(string message) : base(message)
    {
    }

    public InternalRequestException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
