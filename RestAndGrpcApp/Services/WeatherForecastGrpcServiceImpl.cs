using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RestAndGrpcApp.Protos;

namespace RestAndGrpcApp.Server.Services
{
    /// <summary>
    /// WeatherForecasts GRPC service
    /// </summary>
    /// <param name="service"></param>
    public class WeatherForecastGrpcServiceImpl(IWeatherForecastService service) : WeatherForecastGrpcService.WeatherForecastGrpcServiceBase
    {
        private readonly IWeatherForecastService _service = service;

        /// <summary>
        /// Get WeatherForecasts method
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>WeatherForecasts</returns>
        public override Task<WeatherForecasts> GetWeatherForecasts(Empty request, ServerCallContext context)
        {
            return Task.FromResult(_service.Get());
        }

        /// <summary>
        /// Get WeatherForecasts method by quantity
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>WeatherForecasts</returns>
        public override Task<WeatherForecasts> GetWeatherForecastsByQty(WeatherForecastRequest request, ServerCallContext context)
        {
            return Task.FromResult(_service.Get(request.Qty));
        }
    }
}
