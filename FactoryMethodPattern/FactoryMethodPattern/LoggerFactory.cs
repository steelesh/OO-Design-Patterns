namespace FactoryMethodPattern;

public abstract class LoggerFactory
{
    public abstract ILogger CreateLogger();
}