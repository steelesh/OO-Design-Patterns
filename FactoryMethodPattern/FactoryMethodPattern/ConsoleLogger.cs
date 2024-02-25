namespace FactoryMethodPattern;

public class ConsoleLogger : ILogger
{
    public void Log(string msg)
    {
        Console.WriteLine($"Console Logger: {msg}");
    }
}