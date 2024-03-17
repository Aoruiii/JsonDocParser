namespace GameDataParser.ExceptionHandling;

public class Logger
{
    private string _logFilePath;

    public Logger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public void Log(Exception ex)
    {
        string logFilePath = _logFilePath;
        string logMessage = $"[{DateTime.Now}], Exception message: {ex.Message}, Stack trace: {ex.StackTrace}{Environment.NewLine}";
        File.AppendAllText(logFilePath, logMessage);
    }
}