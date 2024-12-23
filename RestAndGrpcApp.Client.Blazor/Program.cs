using Grpc.Net.Client.Web;
using Grpc.Net.Client;
using RestAndGrpcApp.Client.Blazor.Components;
using RestAndGrpcApp.Protos;
using RestAndGrpcApp.Client.Blazor.Clients;

namespace RestAndGrpcApp.Client.Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Add GRPC client
            builder.Services.AddSingleton(services =>
            {
                var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
                var channel = GrpcChannel.ForAddress("http://localhost:5000", new GrpcChannelOptions { HttpClient = httpClient });
                var result = new WeatherForecastGrpcService.WeatherForecastGrpcServiceClient(channel);

                return result;
            });

            builder.Services.AddHttpClient<IWeatherForecastRestClient, WeatherForecastRestClient>(c =>
                c.BaseAddress = new Uri("http://localhost:4999/")
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
