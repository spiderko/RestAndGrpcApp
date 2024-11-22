using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Client.Blazor.Clients
{
    public class WeatherForecastRestClient(HttpClient httpClient) : IWeatherForecastRestClient
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<WeatherForecasts?> GetWeatherForecastsAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecasts>("Rest/WeatherForecast");
        }

        public async Task<WeatherForecasts?> GetWeatherForecastsByQtyAsync(int qty)
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecasts>($"Rest/WeatherForecast/{qty}");
        }
    }
}
