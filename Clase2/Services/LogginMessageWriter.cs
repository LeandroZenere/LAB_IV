namespace Clase2.Services
{
    public class LogginMessageWriter : IMessageWriter
    {
        private readonly ILogger <LogginMessageWriter> _logger;
        public LogginMessageWriter(ILogger<LogginMessageWriter> logger)
        {
            _logger = logger;
        }
        public void Write(string message) =>
            _logger.LogInformation(message);
    }
}
