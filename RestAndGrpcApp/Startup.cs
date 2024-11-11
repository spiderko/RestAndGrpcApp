using System.Reflection;
using Microsoft.OpenApi.Models;
using RestAndGrpcApp.Server.Services;

namespace RestAndGrpcApp
{
    /// <summary>
    /// Startup class
    /// </summary>
    /// <remarks>
    /// Constructor injection
    /// </remarks>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public class Startup(IConfiguration configuration)
    {
        private IConfiguration Configuration { get; } = configuration;

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddGrpc().AddJsonTranscoding();
            services.AddGrpcSwagger();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "RestAndGrpcApp API",
                    Description = "A simple hybrid REST and gRPC service"
                });

                c.DescribeAllParametersInCamelCase();

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            // Registers the service with a scoped lifetime
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <returns></returns>
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestAndGrpcApp v1"));
            }

            app.UseRouting();
            app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                // Communication with gRPC endpoints must be made through a gRPC client.
                // To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909
                endpoints.MapGrpcService<WeatherForecastGrpcServiceImpl>();
            });
        }
    }
}