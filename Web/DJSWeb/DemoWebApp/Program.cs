using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DemoWebApp
{
    public class Program
    {

        // TODO 17 september
        // Update Index Book - DONE
        // Creating Services for Dummy Books. DONE
        // Types of services + Dependency Injection. DONE
        // Async Await
        // Display/Validation Book
        // Create Book
        // Other CRUD

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
}
