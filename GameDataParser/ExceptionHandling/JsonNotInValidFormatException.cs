namespace GameDataParser.ExceptionHandling;


public class JsonNotInValidFormatException : Exception
{
    public string JsonBody { get; }
    public JsonNotInValidFormatException()
    {
    }

    public JsonNotInValidFormatException(string? message) : base(message)
    {
    }

    public JsonNotInValidFormatException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    // public JsonNotInValidFormatException(string message, string jsonBody, Exception? innerException) : base(message, innerException)
    // {
    //     JsonBody = jsonBody;
    // }
}