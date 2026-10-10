using SingletonPattern;

public class Program
{
    public static void Main()
    {
        // Get logger instance
        Logger logger1 = Logger.Instance;
        logger1.Log("Application started.");

        // Another part of the app uses the same logger
        Logger logger2 = Logger.Instance;
        logger2.Log("User logged in.");

        // Verify both references point to same object
        Console.WriteLine(Object.ReferenceEquals(logger1, logger2)
            ? "Same Logger instance shared"
            : "Different logger instances");
    }
}
