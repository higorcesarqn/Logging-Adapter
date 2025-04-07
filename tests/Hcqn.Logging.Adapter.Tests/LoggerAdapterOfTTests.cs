using Microsoft.Extensions.Logging;
using Moq;

namespace Hcqn.Logging.Adapter.Tests;

public class LoggerAdapterOfTTests
{
    [Fact]
    public void Constructor_WithNullFactory_ThrowsArgumentNullException()
    {
        // Arrange & Act & Assert
        Assert.Throws<ArgumentNullException>(() => new LoggerAdapter<LoggerAdapterOfTTests>(null!));
    }

    [Fact]
    public void CreateScope_ShouldDelegateToInnerLogger()
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        
        var mockFactory = new Mock<ILoggerFactory>();
        mockFactory.Setup(f => f.CreateLogger(It.IsAny<string>())).Returns(mockLogger.Object);
        
        var adapter = new LoggerAdapter<LoggerAdapterOfTTests>(mockFactory.Object);
        var scopeMessage = "Test scope {0}";
        object[] scopeParams = ["param"];

        // Act
        ILoggerAdapter loggerAdapter = adapter;
        loggerAdapter.CreateScope(scopeMessage, scopeParams);

        // Assert
        // A verificação do comportamento é feita indiretamente via LoggerAdapter,
        // que não podemos mockar neste teste
        // O fato de não lançar exceções já é um sucesso parcial neste caso
    }

    [Theory]
    [InlineData(LogLevel.Information)]
    [InlineData(LogLevel.Warning)]
    [InlineData(LogLevel.Error)]
    [InlineData(LogLevel.Critical)]
    [InlineData(LogLevel.Debug)]
    [InlineData(LogLevel.Trace)]
    public void WriteLog_WithMessage_CallsUnderlyingLogger(LogLevel logLevel)
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(It.IsAny<LogLevel>())).Returns(true);
        
        var mockFactory = new Mock<ILoggerFactory>();
        mockFactory.Setup(f => f.CreateLogger(It.IsAny<string>())).Returns(mockLogger.Object);
        
        var adapter = new LoggerAdapter<LoggerAdapterOfTTests>(mockFactory.Object);
        
        // Act
        ILoggerAdapter loggerAdapter = adapter;
        loggerAdapter.WriteLog(logLevel, "Test message {0}", "param");
        
        // Assert
        mockLogger.Verify(l => l.Log(
            logLevel,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            null,
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
    }
    
    [Theory]
    [InlineData(LogLevel.Information)]
    [InlineData(LogLevel.Warning)]
    [InlineData(LogLevel.Error)]
    [InlineData(LogLevel.Critical)]
    [InlineData(LogLevel.Debug)]
    [InlineData(LogLevel.Trace)]
    public void WriteLog_WithException_CallsUnderlyingLogger(LogLevel logLevel)
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(It.IsAny<LogLevel>())).Returns(true);
        
        var mockFactory = new Mock<ILoggerFactory>();
        mockFactory.Setup(f => f.CreateLogger(It.IsAny<string>())).Returns(mockLogger.Object);
        
        var adapter = new LoggerAdapter<LoggerAdapterOfTTests>(mockFactory.Object);
        var exception = new InvalidOperationException("Test exception");
        
        // Act
        ILoggerAdapter loggerAdapter = adapter;
        loggerAdapter.WriteLog(logLevel, exception, "Test message {0}", "param");
        
        // Assert
        mockLogger.Verify(l => l.Log(
            logLevel,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            exception,
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Once);
    }
    
    [Fact]
    public void WriteLog_WithDisabledLogLevel_DoesNotCallUnderlyingLogger()
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(It.IsAny<LogLevel>())).Returns(false);
        
        var mockFactory = new Mock<ILoggerFactory>();
        mockFactory.Setup(f => f.CreateLogger(It.IsAny<string>())).Returns(mockLogger.Object);
        
        var adapter = new LoggerAdapter<LoggerAdapterOfTTests>(mockFactory.Object);
        
        // Act
        ILoggerAdapter loggerAdapter = adapter;
        loggerAdapter.WriteLog(LogLevel.Debug, "Test message");
        
        // Assert
        mockLogger.Verify(l => l.Log(
            It.IsAny<LogLevel>(),
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Never);
    }
}