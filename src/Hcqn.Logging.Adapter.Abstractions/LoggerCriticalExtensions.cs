using Hcqn.Logging.Adapter;
using Microsoft.Extensions.Logging;

namespace Dnit.Pnct.Core.Logging
{
    public static class LoggerCriticalExtensions
    {
        /// <summary>
        ///  Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        public static void LogCritical(this ILoggerAdapter logger, string message)
        {
            logger.WriteLog(LogLevel.Critical, message);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        public static void LogCritical<T0>(this ILoggerAdapter logger, string message, T0? t0)
        {
            logger.WriteLog(LogLevel.Critical, message, t0);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        public static void LogCritical<T0, T1>(this ILoggerAdapter logger, string message, T0? t0, T1? t1)
        {
            logger.WriteLog(LogLevel.Critical, message, t0, t1);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public static void LogCritical<T0, T1, T2>(this ILoggerAdapter logger, string message, T0? t0, T1? t1, T2? t2)
        {
            logger.WriteLog(LogLevel.Critical, message, t0, t1, t2);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="logger"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        public static void LogCritical<T0, T1, T2, T3>(this ILoggerAdapter logger, string message, T0? t0, T1? t1, T2? t2, T3? t3)
        {
            logger.WriteLog(LogLevel.Critical, message, t0, t1, t2, t3);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        public static void LogCritical(this ILoggerAdapter logger, Exception? exception, string message)
        {
            logger.WriteLog(LogLevel.Critical, exception, message);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <param name="logger"></param>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        public static void LogCritical<T0>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0)
        {
            logger.WriteLog(LogLevel.Critical, exception, message, t0);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="logger"></param>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        public static void LogCritical<T0, T1>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0, T1? t1)
        {
            logger.WriteLog(LogLevel.Critical, exception, message, t0, t1);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="logger"></param>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public static void LogCritical<T0, T1, T2>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0, T1? t1, T2? t2)
        {
            logger.WriteLog(LogLevel.Critical, exception, message, t0, t1, t2);
        }

        /// <summary>
        /// Registra mensagens para as falhas que exigem atenção imediata
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="logger"></param>
        /// <param name="exception"></param>
        /// <param name="message"></param>
        /// <param name="t0"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        public static void LogCritical<T0, T1, T2, T3>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0, T1? t1, T2? t2, T3? t3)
        {
            logger.WriteLog(LogLevel.Critical, exception, message, t0, t1, t2, t3);
        }
    }
}