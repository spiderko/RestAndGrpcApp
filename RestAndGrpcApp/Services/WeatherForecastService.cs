using Google.Protobuf.WellKnownTypes;
using RestAndGrpcApp.Protos;
using RestAndGrpcApp.Server.Controllers;
using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Server.Services
{

    /// <summary>
    /// WeatherForecastService
    /// </summary>
    public class WeatherForecastService(ILogger<WeatherForecastController> logger) : IWeatherForecastService
    {
        private readonly ILogger<WeatherForecastController> _logger = logger;

        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        /// <summary>
        /// Get method requesting 5 forecasts
        /// </summary>
        /// <returns>WeatherForecasts</returns>
        public WeatherForecasts GetRest()
        {
            return GetRest(5);
        }

        /// <summary>
        /// Get method requesting 5 forecasts
        /// </summary>
        /// <returns>GrpcWeatherForecasts</returns>
        public GrpcWeatherForecasts GetGrpc()
        {
            return GetGrpc(5);
        }

        /// <summary>
        /// Get method with specified quantity
        /// </summary>
        /// <param name="qty">The number of forecasts requested</param>
        /// <returns>WeatherForecasts</returns>
        public WeatherForecasts GetRest(int qty)
        {
            _logger.LogInformation($"Sending {qty} weather forecasts from REST service");
            WeatherForecasts weatherForecasts = new();

            for (int i = 1; i <= qty; i++)
            {
                weatherForecasts.Forecasts.Add(GetWeatherForecast(DateTime.UtcNow));
            }
            return weatherForecasts;
        }

        public GrpcWeatherForecasts GetGrpc(int qty)
        {
            _logger.LogInformation($"Sending {qty} weather forecasts from GRPC service");
            GrpcWeatherForecasts weatherForecasts = new();

            for (int i = 1; i <= qty; i++)
            {
                weatherForecasts.Forecasts.Add(GetWeatherForecast(DateTime.UtcNow.ToTimestamp()));
            }
            return weatherForecasts;
        }

        private static WeatherForecast GetWeatherForecast(DateTime date)
        {
            return new()
            {
                Date = date,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }

        private static GrpcWeatherForecast GetWeatherForecast(Timestamp date)
        {
            return new()
            {
                Date = date,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }
    }
}
