using RestAndGrpcApp.Services;

namespace RestAndGrpcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddGrpc().AddJsonTranscoding();
            builder.Services.AddGrpcSwagger();

            // Add services to the container.
            builder.Services.AddTransient<IWeatherForecastService, WeatherForecastService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestAndGrpcApp v1"));
            }

            app.MapGrpcService<WeatherForecastGrpcServiceImpl>();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
