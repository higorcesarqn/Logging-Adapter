using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter;

public class LoggerAdapter(ILogger logger) : ILoggerAdapter
{
    private readonly ILogger _logger = logger;

    private bool IsEnabled(LogLevel logLevel) => _logger.IsEnabled(logLevel);

    public IDisposable CreateScope(string messageFormat, params object?[] args)
    {
        return _logger.BeginScope(messageFormat, args);
    }

    public void WriteLog(LogLevel logLevel, string? message, params object?[] args)
    {
        if (IsEnabled(logLevel))
        {
            _logger.Log(logLevel, message, args);
        }
    }

    public void WriteLog(LogLevel logLevel, Exception? execption, string? message, params object?[] args)
    {
        if (IsEnabled(logLevel))
        {
            _logger.Log(logLevel, execption, message, args);
        }
    }
}