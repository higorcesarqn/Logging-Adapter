using Hcqn.Logging.Adapter.Abstractions;
using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter;

/// <summary>
/// Implementação genérica de <see cref="ILoggerAdapter{T}"/> que encapsula o logger do tipo T.
/// Fornece métodos para registrar mensagens de log com diferentes níveis de severidade.
/// </summary>
/// <typeparam name="T">O tipo para o qual o logger será criado</typeparam>
public sealed class LoggerAdapter<T> : ILoggerAdapter<T>
{
    private readonly LoggerAdapter _loggerAdapter;

    /// <summary>
    /// Inicializa uma nova instância de <see cref="LoggerAdapter{T}"/>
    /// </summary>
    /// <param name="factory">A fábrica de logger que será usada para criar o logger interno</param>
    /// <exception cref="ArgumentNullException">Lançada quando factory for nulo</exception>
    public LoggerAdapter(ILoggerFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory, nameof(factory));
        _loggerAdapter = new LoggerAdapter(factory.CreateLogger<T>());
    }

    /// <inheritdoc />
    IDisposable ILoggerAdapter.CreateScope(string message, params object?[] args)
    {
        return _loggerAdapter.CreateScope(message, args);
    }

    /// <inheritdoc />
    void ILoggerAdapter.WriteLog(LogLevel logLevel, string? message, params object?[] args)
    {
        _loggerAdapter.WriteLog(logLevel, message, args);
    }

    /// <inheritdoc />
    void ILoggerAdapter.WriteLog(LogLevel logLevel, Exception? execption, string? message, params object?[] args)
    {
        _loggerAdapter.WriteLog(logLevel, execption, message, args);
    }
}