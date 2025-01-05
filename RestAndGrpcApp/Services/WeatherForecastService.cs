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
            var temperatureC = Random.Shared.Next(-20, 55);
            return new()
            {
                Date = date,
                TemperatureC = temperatureC,
                TemperatureF = 32 + (int)((temperatureC / 0.5556)),
                Summary = GetSummary(temperatureC)
            };
        }

        private static GrpcWeatherForecast GetWeatherForecast(Timestamp date)
        {
            var temperatureC = Random.Shared.Next(-20, 55);
            return new()
            {
                Date = date,
                TemperatureC = temperatureC,
                TemperatureF = 32 + (int)((temperatureC / 0.5556)),
                Summary = GetSummary(temperatureC)
            };
        }

        private static string GetSummary(int temperatureC) 
        {
            return temperatureC switch
            {
                < -10 => Summaries[0],
                < 0 => Summaries[1],
                < 10 => Summaries[2],
                < 20 => Summaries[3],
                < 25 => Summaries[4],
                < 30 => Summaries[5],
                < 35 => Summaries[6],
                < 40 => Summaries[7],
                < 50 => Summaries[8],
                _ => Summaries[9],
            };
        }
    }
}
