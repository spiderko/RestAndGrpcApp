using Microsoft.AspNetCore.Mvc;
using RestAndGrpcApp.Protos;
using RestAndGrpcApp.Server.Services;

namespace RestAndGrpcApp.Server.Controllers
{
    /// <summary>
    /// WeatherForecasts REST controller 
    /// </summary>
    /// <param name="service"></param>
    /// <param name="logger"></param>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(IWeatherForecastService service, ILogger<WeatherForecastController> logger) : ControllerBase
    {
        private readonly IWeatherForecastService _service = service;
        private readonly ILogger<WeatherForecastController> _logger = logger;

        [HttpGet(Name = "GetWeatherForecast")]
        public WeatherForecasts Get()
        {
            _logger.LogInformation("Getting weather forecast");
            return _service.Get();
        }
    }
}
