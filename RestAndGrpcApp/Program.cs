using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.OpenApi.Models;
using RestAndGrpcApp.Services;

namespace RestAndGrpcApp
{
    public class Program
    {
        /// <summary>
        /// The entry point of the application
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static async Task Main(string[] args) =>
            await CreateHostBuilder(args).Build().RunAsync();


        /// <summary>
        /// Create and configure a builder object.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.ConfigureKestrel(options =>
                {
                    options.ListenAnyIP(4999, listenOptions =>
                        listenOptions.Protocols = HttpProtocols.Http1);

                    options.ListenAnyIP(5000, listenOptions =>
                        listenOptions.Protocols = HttpProtocols.Http2);
                })
                    .UseStartup<Startup>());
    }
}
