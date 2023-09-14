namespace Clase2.Middleware
{
    public static class MyCustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddeleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleware>();
        }
    }
}
