using Hcqn.Logging.Adapter;

namespace Dnit.Pnct.Core.Logging
{
    public static class LoggerScopeExtensions
    {
        /// <summary>
        /// Formata a mensagem e cria um escopo.
        /// </summary>
        /// <param name="loggerAdapter"></param>
        /// <param name="messageFormat"></param>
        /// <returns></returns>
        public static IDisposable BeginScope(this ILoggerAdapter loggerAdapter, string messageFormat)
        {
            return loggerAdapter.CreateScope(messageFormat);
        }

        /// <summary>
        /// Formata a mensagem e cria um escopo.
        /// </summary>
        /// <param name="loggerAdapter"></param>
        /// <param name="messageFormat"></param>
        /// <returns></returns>
        public static IDisposable BeginScope<T0>(this ILoggerAdapter loggerAdapter, string messageFormat, T0 t0)
        {
            return loggerAdapter.CreateScope(messageFormat, t0);
        }

        /// <summary>
        /// Formata a mensagem e cria um escopo.
        /// </summary>
        /// <param name="loggerAdapter"></param>
        /// <param name="messageFormat"></param>
        /// <returns></returns>
        public static IDisposable BeginScope<T0, T1>(this ILoggerAdapter loggerAdapter, string messageFormat, T0 t0, T1 t1)
        {
            return loggerAdapter.CreateScope(messageFormat, t0, t1);
        }

        /// <summary>
        /// Formata a mensagem e cria um escopo.
        /// </summary>
        /// <param name="loggerAdapter"></param>
        /// <param name="messageFormat"></param>
        /// <returns></returns>
        public static IDisposable BeginScope<T0, T1, T2>(this ILoggerAdapter loggerAdapter, string messageFormat, T0 t0, T1 t1, T2 t2)
        {
            return loggerAdapter.CreateScope(messageFormat, t0, t1, t2);
        }

        /// <summary>
        /// Formata a mensagem e cria um escopo.
        /// </summary>
        /// <param name="loggerAdapter"></param>
        /// <param name="messageFormat"></param>
        /// <returns></returns>
        public static IDisposable BeginScope<T0, T1, T2, T3>(this ILoggerAdapter loggerAdapter, string messageFormat, T0 t0, T1 t1, T2 t2, T3 t3)
        {
            return loggerAdapter.CreateScope(messageFormat, t0, t1, t2, t3);
        }
    }
}