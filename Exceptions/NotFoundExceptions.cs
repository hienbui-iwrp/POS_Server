namespace POS_server.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base($"Not found: {message}")
    {
    }
}