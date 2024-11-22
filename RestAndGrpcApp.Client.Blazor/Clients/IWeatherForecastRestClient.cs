using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Client.Blazor.Clients
{
    public interface IWeatherForecastRestClient
    {
        Task<WeatherForecasts?> GetWeatherForecastsAsync();
    }
}