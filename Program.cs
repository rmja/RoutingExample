using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using System.IO;

namespace RoutingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseDefaultHostingConfiguration(args)
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
