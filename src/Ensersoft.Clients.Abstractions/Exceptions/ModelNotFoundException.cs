namespace Ensersoft.Clients.Abstractions.Exceptions;

public class ModelNotFoundException : Exception
{
    public ModelNotFoundException(string message) : base(message)
    {
    }

    public ModelNotFoundException()
    {
    }

    public ModelNotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}