internal sealed class LoggerExampleUsage
{
    public void LogMessages()
    {
        Logger logger = Logger.Instance;

        logger.Log("Application started.");
        logger.Log("Performing some operations...");
        logger.Log("Application ended.");
    }
}