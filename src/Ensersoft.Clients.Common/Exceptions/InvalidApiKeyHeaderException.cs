namespace Ensersoft.Clients.Common.Exceptions;

public class InvalidApiKeyHeaderException : Exception
{
    public InvalidApiKeyHeaderException(string message) : base(message)
    {
    }

    public InvalidApiKeyHeaderException()
    {
    }

    public InvalidApiKeyHeaderException(string message, Exception innerException) : base(message, innerException)
    {
    }
}