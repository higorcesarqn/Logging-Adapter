using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter.Abstractions;

public static class LoggerFactoryExtensions
{
    public static ILoggerAdapter<T> CreateLoggerAdapter<T>(this ILoggerFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory, nameof(factory));
        return new LoggerAdapter<T>(factory);
    }

    public static ILoggerAdapter CreateLoggerAdapter(this ILoggerFactory factory, Type type)
    {
        ArgumentNullException.ThrowIfNull(factory, nameof(factory));
        return new LoggerAdapter(factory.CreateLogger(type));
    }
}