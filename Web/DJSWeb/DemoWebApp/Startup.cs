using DemoWebApp.Business;
using DemoWebApp.Business.Interfaces;
using DemoWebApp.Services;
using DemoWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DemoWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Our own services:
            services.AddSingleton<IBookService, DummyBookService>();
            services.AddScoped<IRentals, Rentals>();

            services.AddControllersWithViews();

            // used to add services to the runtime.
            /* .NET Core
             * 
             *  services.AddTransient(IRepository, Repository);
             */
            /*
             * Spring Boot:
             * @Repository
             * public interface RoomRepo extends ICrudRepo<Room>
             * 
             * Controller
             * 
             * @Dependency
             * private RoomRepo repo;
             */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
