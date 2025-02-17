namespace CounterAPI
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var logText = $"Service called at: {DateTime.Now}\n";
            await File.AppendAllTextAsync("log.txt", logText);

            await _next(context);

        }
    }
}
