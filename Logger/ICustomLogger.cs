using System;
using System.IO;

public interface ICustomLogger
{
    void LogInformation(string message);
    void LogError(string message);
    void LogWarning(string message);
}

