using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter.Abstractions;

public static class LoggerWarningExtensions
{
    /// <summary>
    ///  Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="message"></param>
    public static void LogWarning(this ILoggerAdapter logger, string message)
    {
        logger.WriteLog(LogLevel.Warning, message);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <param name="logger"></param>
    /// <param name="message"></param>
    /// <param name="t0"></param>
    public static void LogWarning<T0>(this ILoggerAdapter logger, string message, T0? t0)
    {
        logger.WriteLog(LogLevel.Warning, message, t0);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <typeparam name="T1"></typeparam>
    /// <param name="logger"></param>
    /// <param name="message"></param>
    /// <param name="t0"></param>
    /// <param name="t1"></param>
    public static void LogWarning<T0, T1>(this ILoggerAdapter logger, string message, T0? t0, T1? t1)
    {
        logger.WriteLog(LogLevel.Warning, message, t0, t1);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="logger"></param>
    /// <param name="message"></param>
    /// <param name="t0"></param>
    /// <param name="t1"></param>
    /// <param name="t2"></param>
    public static void LogWarning<T0, T1, T2>(this ILoggerAdapter logger, string message, T0? t0, T1? t1, T2? t2)
    {
        logger.WriteLog(LogLevel.Warning, message, t0, t1, t2);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
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
    public static void LogWarning<T0, T1, T2, T3>(this ILoggerAdapter logger, string message, T0? t0, T1? t1, T2? t2, T3? t3)
    {
        logger.WriteLog(LogLevel.Warning, message, t0, t1, t2, t3);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="exception"></param>
    /// <param name="message"></param>
    public static void LogWarning(this ILoggerAdapter logger, Exception? exception, string message)
    {
        logger.WriteLog(LogLevel.Warning, exception, message);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <param name="logger"></param>
    /// <param name="exception"></param>
    /// <param name="message"></param>
    /// <param name="t0"></param>
    public static void LogWarning<T0>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0)
    {
        logger.WriteLog(LogLevel.Warning, exception, message, t0);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
    /// </summary>
    /// <typeparam name="T0"></typeparam>
    /// <typeparam name="T1"></typeparam>
    /// <param name="logger"></param>
    /// <param name="exception"></param>
    /// <param name="message"></param>
    /// <param name="t0"></param>
    /// <param name="t1"></param>
    public static void LogWarning<T0, T1>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0, T1? t1)
    {
        logger.WriteLog(LogLevel.Warning, exception, message, t0, t1);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
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
    public static void LogWarning<T0, T1, T2>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0, T1? t1, T2? t2)
    {
        logger.WriteLog(LogLevel.Warning, exception, message, t0, t1, t2);
    }

    /// <summary>
    /// Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo
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
    public static void LogWarning<T0, T1, T2, T3>(this ILoggerAdapter logger, Exception? exception, string message, T0? t0, T1? t1, T2? t2, T3? t3)
    {
        logger.WriteLog(LogLevel.Warning, exception, message, t0, t1, t2, t3);
    }
}