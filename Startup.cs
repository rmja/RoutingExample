using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace RoutingExample
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithManufacturerAndId",
                    template: "{area:exists}/{manufacturer}/{controller}/{action}/{id}");

                routes.MapRoute(
                    name: "defaultWithManufacturer",
                    template: "{area:exists}/{manufacturer}/{controller}/{action=Index}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}");
            });
        }
    }
}
