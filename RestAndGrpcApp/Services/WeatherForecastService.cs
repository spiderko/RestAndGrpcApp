using Google.Protobuf.WellKnownTypes;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        public WeatherForecasts Get()
        {
            WeatherForecasts weatherForecasts = new();

            for (int i = 1; i < 5; i++)
            {
                weatherForecasts.Forecasts.Add(GetWeatherForecast(Timestamp.FromDateTime(DateTime.UtcNow)));
            }
            

            return weatherForecasts;
        }

        public WeatherForecast Get(string date, string city)
        {
            return GetWeatherForecast(GetTimestamp(date), city);
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

        private static WeatherForecast GetWeatherForecast(Timestamp date, string city)
        {
            return new()
            {
                Date = date,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)] + " in " + city
            };
        }

        private static Timestamp GetTimestamp(string date)
        {
            return Timestamp.FromDateTime(DateTime.SpecifyKind(DateTime.Parse(date), DateTimeKind.Utc));
        }
    }
}
