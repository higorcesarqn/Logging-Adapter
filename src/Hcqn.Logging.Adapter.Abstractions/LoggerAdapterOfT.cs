using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter.Abstractions
{
    internal class LoggerAdapter<T> : ILoggerAdapter<T>
    {
        private readonly ILoggerAdapter _loggerAdapter;

        public LoggerAdapter(ILoggerFactory factory)
        {
            ArgumentNullException.ThrowIfNull(factory, nameof(factory));
            _loggerAdapter = new LoggerAdapter(factory.CreateLogger<T>());
        }

        IDisposable ILoggerAdapter.CreateScope(string message, params object?[] args)
        {
            return _loggerAdapter.CreateScope(message, args);
        }

        void ILoggerAdapter.WriteLog(LogLevel logLevel, string? message, params object?[] args)
        {
            _loggerAdapter.WriteLog(logLevel, message, args);
        }

        void ILoggerAdapter.WriteLog(LogLevel logLevel, Exception? execption, string? message, params object?[] args)
        {
            _loggerAdapter.WriteLog(logLevel, execption, message, args);
        }
    }
}