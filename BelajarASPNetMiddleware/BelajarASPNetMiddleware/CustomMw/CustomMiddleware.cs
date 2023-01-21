namespace BelajarASPNetMiddleware.CustomMw
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate next;
        public CustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("CustomMiddleware");

            Console.WriteLine("Custom Middleware");
        }
    }
}
