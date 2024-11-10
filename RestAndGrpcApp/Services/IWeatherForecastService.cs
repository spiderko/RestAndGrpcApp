using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services
{
    public interface IWeatherForecastService
    {
        WeatherForecasts Get();
        WeatherForecast Get(string date, string city);
    }
}