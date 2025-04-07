using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter;

/// <summary>
/// Implementação do adaptador de logger que encapsula um logger do Microsoft.Extensions.Logging.
/// Esta classe fornece uma camada de abstração sobre o sistema de logging padrão.
/// </summary>
public sealed class LoggerAdapter : ILoggerAdapter
{
    private readonly ILogger _logger;

    /// <summary>
    /// Inicializa uma nova instância de <see cref="LoggerAdapter"/>.
    /// </summary>
    /// <param name="logger">O logger subjacente a ser encapsulado</param>
    /// <exception cref="System.ArgumentNullException">Lançada quando o logger é nulo</exception>
    public LoggerAdapter(ILogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Verifica se o nível de log especificado está habilitado.
    /// </summary>
    /// <param name="logLevel">O nível de log a ser verificado</param>
    /// <returns>Verdadeiro se o nível de log estiver habilitado; caso contrário, falso</returns>
    private bool IsEnabled(LogLevel logLevel) => _logger.IsEnabled(logLevel);

    /// <inheritdoc />
    public IDisposable CreateScope(string messageFormat, params object?[] args)
    {
        return _logger.BeginScope(messageFormat, args);
    }

    /// <inheritdoc />
    public void WriteLog(LogLevel logLevel, string? message, params object?[] args)
    {
        if (IsEnabled(logLevel))
        {
            _logger.Log(logLevel, message, args);
        }
    }

    /// <inheritdoc />
    public void WriteLog(LogLevel logLevel, Exception? exception, string? message, params object?[] args)
    {
        if (IsEnabled(logLevel))
        {
            _logger.Log(logLevel, exception, message, args);
        }
    }
}