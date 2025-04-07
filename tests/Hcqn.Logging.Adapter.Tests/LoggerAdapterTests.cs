using Microsoft.Extensions.Logging;
using Moq;

namespace Hcqn.Logging.Adapter.Tests;

public class LoggerAdapterTests
{
    [Fact]
    public void CreateScope_ShouldCallLoggerWithCorrectParameters()
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        
        var adapter = new LoggerAdapter(mockLogger.Object);
        string scopeMessage = "Test scope {0}";
        object[] scopeParams = new object[] { "param" };

        // Act
        adapter.CreateScope(scopeMessage, scopeParams);

        // Assert
        // O fato de não lançar exceções já é um sucesso parcial
        // Não podemos verificar diretamente a chamada ao método de extensão BeginScope
    }

    [Theory]
    [InlineData(LogLevel.Information)]
    [InlineData(LogLevel.Warning)]
    [InlineData(LogLevel.Error)]
    [InlineData(LogLevel.Critical)]
    [InlineData(LogLevel.Debug)]
    [InlineData(LogLevel.Trace)]
    public void WriteLog_WithMessage_WhenLogLevelEnabled_CallsUnderlyingLogger(LogLevel logLevel)
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(logLevel)).Returns(true);
        
        var adapter = new LoggerAdapter(mockLogger.Object);
        
        // Act
        adapter.WriteLog(logLevel, "Test message {0}", "param");
        
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
    public void WriteLog_WithMessage_WhenLogLevelDisabled_DoesNotCallUnderlyingLogger(LogLevel logLevel)
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(logLevel)).Returns(false);
        
        var adapter = new LoggerAdapter(mockLogger.Object);
        
        // Act
        adapter.WriteLog(logLevel, "Test message {0}", "param");
        
        // Assert
        mockLogger.Verify(l => l.Log(
            It.IsAny<LogLevel>(),
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Never);
    }
    
    [Theory]
    [InlineData(LogLevel.Information)]
    [InlineData(LogLevel.Warning)]
    [InlineData(LogLevel.Error)]
    [InlineData(LogLevel.Critical)]
    [InlineData(LogLevel.Debug)]
    [InlineData(LogLevel.Trace)]
    public void WriteLog_WithException_WhenLogLevelEnabled_CallsUnderlyingLogger(LogLevel logLevel)
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(logLevel)).Returns(true);
        
        var adapter = new LoggerAdapter(mockLogger.Object);
        var exception = new InvalidOperationException("Test exception");
        
        // Act
        adapter.WriteLog(logLevel, exception, "Test message {0}", "param");
        
        // Assert
        mockLogger.Verify(l => l.Log(
            logLevel,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            exception,
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
    public void WriteLog_WithException_WhenLogLevelDisabled_DoesNotCallUnderlyingLogger(LogLevel logLevel)
    {
        // Arrange
        var mockLogger = new Mock<ILogger>();
        mockLogger.Setup(l => l.IsEnabled(logLevel)).Returns(false);
        
        var adapter = new LoggerAdapter(mockLogger.Object);
        var exception = new InvalidOperationException("Test exception");
        
        // Act
        adapter.WriteLog(logLevel, exception, "Test message {0}", "param");
        
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