using System;

namespace SingletonPattern;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
    public static Logger Instance => _instance.Value;

    private Logger()
    {
        Console.WriteLine("Logger Initialised");
    }
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}
