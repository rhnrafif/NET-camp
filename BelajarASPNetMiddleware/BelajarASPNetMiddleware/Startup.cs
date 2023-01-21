using BelajarASPNetMiddleware.CustomMw;
using System.Text.Json.Serialization;
namespace BelajarASPNetMiddleware
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureService(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options =>
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<CustomMiddleware>();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.Use(async (context, next) =>
            {
                Console.WriteLine("Middleware here");
                await next();
                Console.WriteLine(context.Response.StatusCode);
            });

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllers();
            });
        }
    }
}
