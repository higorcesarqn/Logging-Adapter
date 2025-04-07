using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter;

public sealed class NullLoggerAdapter : ILoggerAdapter
{
    public static ILoggerAdapter Instance { get; } = new NullLoggerAdapter();

    private NullLoggerAdapter()
    {
    }

    public void WriteLog(LogLevel logLevel, string? message, params object?[] args)
    {
        // intencionalmente não faz nada
    }

    public void WriteLog(LogLevel logLevel, Exception? execption, string? message, params object?[] args)
    {
        // intencionalmente não faz nada
    }

    public IDisposable CreateScope(string message, params object?[] args)
    {
        return NullDisposable.Instance;
    }

    private class NullDisposable : IDisposable
    {
        public static readonly NullDisposable Instance = new();

        public void Dispose()
        {
            // intencionalmente não faz nada
        }
    }
}