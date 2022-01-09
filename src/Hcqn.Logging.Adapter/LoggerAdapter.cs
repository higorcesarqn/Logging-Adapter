using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "Confia")]
    public class LoggerAdapter : ILoggerAdapter
    {
        private readonly ILogger _logger;

        public LoggerAdapter(ILogger logger)
        {
            _logger = logger;
        }

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
}