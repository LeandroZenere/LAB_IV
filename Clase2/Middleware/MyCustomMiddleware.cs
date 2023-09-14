using Clase2.Services;

namespace Clase2.Middleware
{
    public class MyCustomMiddleware
    {
        private readonly RequestDelegate _next;

        public MyCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // IMessageWriter is injected into InvokeAsync
        public async Task InvokeAsync(HttpContext httpContext, IMessageWriter _iMessageWriter)
        {

            //httpContext.Response.Redirect("http://www.google.com");
            var Protocol = httpContext.Request.Protocol;
            var Host = httpContext.Request.Host;
            var Port = httpContext.Request.Host.Port;
            var PathAndQuery = httpContext.Request.Path;

            _iMessageWriter.Write("Protocol: " + Protocol + " Host: " + Host + " Port: " + Port + " PathAndQuery: " + PathAndQuery);
            await _next(httpContext);
        }
    }
}
