using Microsoft.AspNetCore.Mvc;
using RestAndGrpcApp.Protos;
using RestAndGrpcApp.Services;

namespace RestAndGrpcApp.Controllers
{
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
