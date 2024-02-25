namespace FactoryMethodPattern;

public class FileLogger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine($"File Logger: {msg}");
    }
}