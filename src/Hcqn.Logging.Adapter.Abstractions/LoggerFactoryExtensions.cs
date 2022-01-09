using Hcqn.Logging.Adapter;
using Hcqn.Logging.Adapter.Abstractions;

namespace Microsoft.Extensions.Logging
{
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
}