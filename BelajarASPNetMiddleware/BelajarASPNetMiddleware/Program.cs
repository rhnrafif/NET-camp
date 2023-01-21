
#region Hide
//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//Pengenalan Middleware

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello World from first delegate \r\n");
//    await next.Invoke();
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Hello World from second delegate \r\n");
//    await next.Invoke();
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello World from third delegate");
//});

//app.Run();

////method map untuk melakukan branching atau mapping
//app.Map("/map1", HandleMap1);
//app.Map("/map2", HandleMap2);
//app.Map("/map1/seg1", HandleSeg1);

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("hello from non map delegate");
//});

//app.Run();

//static void HandleMap1(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map 1");
//    });
//}
//static void HandleMap2(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Map 2");
//    });
//}

//static void HandleSeg1(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        await context.Response.WriteAsync("Segment 1");
//    });
//}

//segment Branching
//app.Map("/newbranch", a =>
//{
//    a.Map("/branch1", brancha => brancha.Run(c => c.Response.WriteAsync("Running from newbranch/branch1 branch")));
//    a.Map("/branch2", brancha => brancha.Run(c => c.Response.WriteAsync("Running from newbranch/branch2 branch")));

//    a.Run(c => c.Response.WriteAsync("Runnig from the newbranch branch"));
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Another hello world");
//});

//app.Run();

//search dan filter dalam endpoint menggunakan tanda tanya (query param)
//jika yang dicari spesifik menggunakan slash / . misalnya id, dll.
//mapwhen, digunakan untuk merequest pipeline berdasarkan hasil yang diberikan dalam predicate
//app.MapWhen(context => context.Request.Query.ContainsKey("branch"), HandleBranch);

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello From non delgeate branch");
//});
//app.Run();
//static void HandleBranch(IApplicationBuilder app)
//{
//    app.Run(async context =>
//    {
//        var branchVer = context.Request.Query["branch"];
//        await context.Response.WriteAsync($"Branch used is {branchVer}");
//    });
//}

#endregion

using BelajarASPNetMiddleware;
using Microsoft.AspNetCore;

public class Program
{
    public static void Main(string[] args)
    {

    }

    private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
}
