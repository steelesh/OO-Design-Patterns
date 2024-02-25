namespace SingletonPattern;

public sealed class Singleton
{
    private static Singleton? _instance;
    private string? _value;

    private Singleton(){}

    public static Singleton GetInstance()
    {
        return _instance ??= new Singleton();
    }

    public string? GetValue()
    {
        return _value;
    }

    public void SetValue(string str)
    {
        _value = str;
    }
}