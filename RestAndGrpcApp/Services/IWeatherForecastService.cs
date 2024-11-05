using Google.Protobuf.WellKnownTypes;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Services
{
    public interface IWeatherForecastService
    {
        WeatherForecasts Get();
        WeatherForecast Get(string date,string city);
    }
}