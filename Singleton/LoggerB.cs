internal class LoggerB
{
    private static LoggerB _instance;
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation from outside
    private LoggerB() { }

    public static LoggerB Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoggerB();
                    }
                }
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        // Simple log to console for demonstration purposes
        Console.WriteLine($"{DateTime.Now}: {message}");
    }
}