using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Services
{
    public interface IWeatherForecastService
    {
        WeatherForecasts Get();
    }
}