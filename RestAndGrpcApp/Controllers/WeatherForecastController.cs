using Microsoft.AspNetCore.Mvc;
using RestAndGrpcApp.Server.Services;
using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Server.Controllers
{
    /// <summary>
    /// WeatherForecasts REST controller 
    /// </summary>
    /// <param name="service"></param>
    /// <param name="logger"></param>
    [ApiController]
    [Route("Rest/[controller]")]
    public class WeatherForecastController(IWeatherForecastService service, ILogger<WeatherForecastController> logger) : ControllerBase
    {
        private readonly IWeatherForecastService _service = service;
        private readonly ILogger<WeatherForecastController> _logger = logger;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public WeatherForecasts Get()
        {
            _logger.LogInformation("Getting 5 weather forecasts");
            return _service.GetRest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qty"></param>
        /// <returns></returns>
        [HttpGet("{qty}")]
        public WeatherForecasts GetQty([FromRoute] int qty)
        {
            _logger.LogInformation($"Getting {qty} weather forecasts");
            return _service.GetRest(qty);
        }
    }
}
