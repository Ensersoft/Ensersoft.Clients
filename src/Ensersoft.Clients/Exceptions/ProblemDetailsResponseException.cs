using Microsoft.AspNetCore.Mvc;

namespace Ensersoft.Clients.Exceptions;

public class ProblemDetailsResponseException : Exception
{
    public ProblemDetails? ProblemDetails { get; }

    public ProblemDetailsResponseException(ProblemDetails problemDetails)
    {
        ProblemDetails = problemDetails;
    }

    public ProblemDetailsResponseException()
    {
    }

    public ProblemDetailsResponseException(string message) : base(message)
    {
    }

    public ProblemDetailsResponseException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
