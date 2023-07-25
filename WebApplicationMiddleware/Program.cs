//using static System.Net.Mime.MediaTypeNames;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//using System;

//namespace WebApplicationMiddleware
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            //// Add services to the container.
//            //builder.Services.AddRazorPages();

//            var app = builder.Build();

//            //// Configure the HTTP request pipeline.
//            //if (!app.Environment.IsDevelopment())
//            //{
//            //    app.UseExceptionHandler("/Error");
//            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//            //    app.UseHsts();
//            //}

//            //app.UseHttpsRedirection();
//            //app.UseStaticFiles();

//            //app.UseRouting();

//            //app.UseAuthorization();

//            //app.MapRazorPages();


//app.Run();
//        }
//    }
//}
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using WebApplicationMiddleware;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configuration services
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        // Add the RequestCarMiddleware to the pipeline
        app.UseRequestCarMiddleware();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello, this is the default route.");
            });
        });
    }
}


public class RequestCarMiddleware
{
    private readonly RequestDelegate _next;

    public RequestCarMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        // Create an instance of the Car class
        // Student studentName1 = new Student(1, "Rembrant", "R", 13, "Milan", course);
        Car car1 = new Car("Renault", "V6", 3);

        // Print car information
        Console.WriteLine("Car Name: " + car1.GetCarName());
        Console.WriteLine("Car Engine: " + car1.GetCarEngine());
        Console.WriteLine("Car Age: " + car1.GetCarAge());

        // Write car information to the response
        await httpContext.Response.WriteAsync($"Car Name: {car1.GetCarName()}\n");
        await httpContext.Response.WriteAsync($"Car Engine: {car1.GetCarEngine()}\n");
        await httpContext.Response.WriteAsync($"Car Age: {car1.GetCarAge()}\n");

        // Call the next middleware or route handler
        await _next(httpContext);
    }
}

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseRequestCarMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestCarMiddleware>();
    }
}
