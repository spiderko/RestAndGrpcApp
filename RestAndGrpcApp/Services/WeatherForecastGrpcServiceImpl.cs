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
        public override Task<GrpcWeatherForecasts> GetWeatherForecasts(Empty request, ServerCallContext context)
        {
            return Task.FromResult(_service.GetGrpc());
        }

        /// <summary>
        /// Get WeatherForecasts method by quantity
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>WeatherForecasts</returns>
        public override Task<GrpcWeatherForecasts> GetWeatherForecastsByQty(WeatherForecastRequest request, ServerCallContext context)
        {
            return Task.FromResult(_service.GetGrpc(request.Qty));
        }
    }
}
