using RestAndGrpcApp.Client.Blazor.Clients;
using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Client.Blazor.Services
{
    public class WeatherForecastService(IWeatherForecastRestClient client)
    {
        private readonly IWeatherForecastRestClient _client = client;

        public async Task<WeatherForecasts?> GetWeatherForecasts()
        {
            var forecasts = await _client.GetWeatherForecastsAsync();

            return forecasts;
        }
    }
}
