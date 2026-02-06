public sealed class Logger
{
    // 1. Private static instance (lazy)
    private static readonly Lazy<Logger> _instance =
        new Lazy<Logger>(() => new Logger());


    // 2. Public access point
    public static Logger Instance => _instance.Value;

    // 3. Private constructor
    private Logger()
    {
        Console.WriteLine("Logger created");
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
