namespace LinkedListKata.Helpers.Loggers;
public class LoggerDummy : ILogger
{
    /*
    <summary>
        This method does the information log level logging.
    </summary>
    <param>
        message to log.
    </param>
    <param>
        args is the logged method's argument. 
        The message describes the modification done to it in the logged method. 
    </param>
    */
    public void LogInformation(string? message)
    {
        string path = Path.Combine
        (
            Directory.GetCurrentDirectory(), 
            @"Helpers\Loggers\Logs\Log.txt"
        );
        if(! File.Exists(path))
            File.Create(path);
        File.AppendAllText(path, string.Concat(message, Environment.NewLine));
    }
    /*
    <summary>
        The implementation is only there because it's mandatory implementing ILogger.
    </summary>
    <param>
        LogLevel is either
            - Critical
            - Error
            - Warning
            - Information
            - Trace
            - Debug
            - None
    </param>
    <returns>
        true if loglevel is any except LogLevel.None.
    </returns>
    */
    public bool IsEnabled(LogLevel logLevel)
    {
        return logLevel != LogLevel.None;
    }
    /*
    <summary>
        The implementation is only there because it's mandatory implementing ILogger.
    </summary>
    */
    public IDisposable? BeginScope<TState>(TState tstate) where TState : notnull
    {
        this.BeginScope(tstate);
        return (IDisposable)this;
    }
    /*
    <summary>
        The implementation is only there because it's mandatory implementing ILogger.
    </summary>
    */
    public void Log<TState>(
        LogLevel logLevel, 
        EventId eventId, 
        TState tstate,
        Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        if(! IsEnabled(logLevel))
            return;
    }
}