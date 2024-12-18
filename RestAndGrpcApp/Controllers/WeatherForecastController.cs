using Microsoft.AspNetCore.Mvc;
using RestAndGrpcApp.Server.Services;
using RestAndGrpcApp.Shared.Models;

namespace RestAndGrpcApp.Server.Controllers
{
    /// <summary>
    /// WeatherForecasts REST controller 
    /// </summary>
    /// <param name="service"></param>
    [ApiController]
    [Route("Rest/[controller]")]
    public class WeatherForecastController(IWeatherForecastService service) : ControllerBase
    {
        private readonly IWeatherForecastService _service = service;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public WeatherForecasts Get()
        {
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
            return _service.GetRest(qty);
        }
    }
}
