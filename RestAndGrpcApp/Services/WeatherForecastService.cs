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
                weatherForecasts.Forecasts.Add(new Protos.WeatherForecast()
                {
                    Date = Timestamp.FromDateTime(DateTime.UtcNow.AddDays(i)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                });
            }
            

            return weatherForecasts;
        }
    }
}
