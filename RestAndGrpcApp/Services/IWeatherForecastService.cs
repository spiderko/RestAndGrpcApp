using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services
{
    public interface IWeatherForecastService
    {
        WeatherForecasts Get();
        WeatherForecasts Get(int qty);
    }
}