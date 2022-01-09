using Microsoft.Extensions.Logging;

namespace Hcqn.Logging.Adapter
{
    /// <summary>
    /// [Trace	     0	Loga mensagens apenas para fins de rastreamento para os desenvolvedores]
    /// [Debug	     1	Loga mensagens para fins de depuração de curto prazo]
    /// [Information 2	Loga mensagens para o fluxo do aplicativo.]
    /// [Warning	 3	Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo.]
    /// [Error	     4	Loga mensagens de erros.
    /// [Critical    5	Registra mensagens para as falhas que exigem atenção imediata]
    /// </summary>
    public interface ILoggerAdapter
    {
        /// <summary>
        /// Formata a mensagem e cria um escopo.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        IDisposable CreateScope(string message, params object?[] args);

        /// <summary>
        /// [Trace	     0	Loga mensagens apenas para fins de rastreamento para os desenvolvedores]
        /// [Debug	     1	Loga mensagens para fins de depuração de curto prazo]
        /// [Information 2	Loga mensagens para o fluxo do aplicativo.]
        /// [Warning	 3	Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo.]
        /// [Error	     4	Loga mensagens de erros.
        /// [Critical    5	Registra mensagens para as falhas que exigem atenção imediata]
        /// </summary>
        /// <param name="logLevel">
        /// </param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void WriteLog(LogLevel logLevel, string? message, params object?[] args);

        /// <summary>
        /// [Trace	     0	Loga mensagens apenas para fins de rastreamento para os desenvolvedores]
        /// [Debug	     1	Loga mensagens para fins de depuração de curto prazo]
        /// [Information 2	Loga mensagens para o fluxo do aplicativo.]
        /// [Warning	 3	Loga mensagens para eventos anormais ou inesperados no fluxo do aplicativo.]
        /// [Error	     4	Loga mensagens de erros.
        /// [Critical    5	Registra mensagens para as falhas que exigem atenção imediata]
        /// </summary>
        /// <param name="logLevel"></param>
        /// <param name="execption"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void WriteLog(LogLevel logLevel, Exception? execption, string? message, params object?[] args);
    }
}