namespace GameDataParser.ExceptionHandling;

public static class Logger
{
    public static void log(Exception ex)
    {
        string logFilePath = "log.txt";
        string logMessage = $"[{DateTime.Now}], Exception message: {ex.Message}, Stack trace: {ex.StackTrace}{Environment.NewLine}";
        File.AppendAllText(logFilePath, logMessage);
    }
}