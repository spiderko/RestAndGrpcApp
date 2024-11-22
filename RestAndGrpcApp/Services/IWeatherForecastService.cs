using RestAndGrpcApp.Protos;
using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Server.Services
{
    public interface IWeatherForecastService
    {
        WeatherForecasts GetRest();
        GrpcWeatherForecasts GetGrpc();
        GrpcWeatherForecasts GetGrpc(int qty);
        WeatherForecasts GetRest(int qty);
    }
}