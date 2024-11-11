using Google.Protobuf.WellKnownTypes;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services
{
    /// <summary>
    /// WeatherForecastService
    /// </summary>
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        /// <summary>
        /// Get method requesting 5 forecasts
        /// </summary>
        /// <returns>WeatherForecasts</returns>
        public WeatherForecasts Get()
        {
            return Get(5);
        }

        /// <summary>
        /// Get method with specified quantity
        /// </summary>
        /// <param name="qty">The number of forecasts requested</param>
        /// <returns>WeatherForecasts</returns>
        public WeatherForecasts Get(int qty)
        {
            WeatherForecasts weatherForecasts = new();

            for (int i = 1; i <= qty; i++)
            {
                weatherForecasts.Forecasts.Add(GetWeatherForecast(Timestamp.FromDateTime(DateTime.UtcNow)));
            }


            return weatherForecasts;
        }

        private static WeatherForecast GetWeatherForecast(Timestamp date)
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
