using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Services
{
    public class WeatherForecastGrpcServiceImpl(IWeatherForecastService service) : WeatherForecastGrpcService.WeatherForecastGrpcServiceBase
    {
        private readonly IWeatherForecastService _service = service;

        public override Task<WeatherForecasts> GetWeatherForecasts(Empty request, ServerCallContext context)
        {
            return Task.FromResult(_service.Get());
        }

        public override Task<WeatherForecast> GetWeatherForecast(WeatherForecastRequest request, ServerCallContext context)
        {
            return Task.FromResult(_service.Get(request.Date, request.City));
        }
    }
}
