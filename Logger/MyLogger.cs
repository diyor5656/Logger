using System;
using System.IO;

public class CustomLogger : ICustomLogger
{
    private readonly string _logFilePath;

    public CustomLogger(string logFilePath = "logs.txt")
    {
        _logFilePath = logFilePath;
    }

    public void LogInformation(string message)
    {
        Log("INFO", message);
    }

    public void LogError(string message)
    {
        Log("ERROR", message);
    }

    public void LogWarning(string message)
    {
        Log("WARNING", message);
    }

    private void Log(string level, string message)
    {
        string formattedMessage = $"{DateTime.Now} [{level}] {message}";

        
        Console.WriteLine(formattedMessage);

        
        try
        {
            File.AppendAllText(_logFilePath, formattedMessage + Environment.NewLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Faylga yozishda xatolik: {ex.Message}");
        }
    }
}
