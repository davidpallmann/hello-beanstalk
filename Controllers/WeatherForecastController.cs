using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hello_beanstalk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public WeatherForecast[] Get()
        {
            DateTime today = DateTime.Today;
            return new WeatherForecast[] {
                GetDailyForecast(today),
                GetDailyForecast(today.AddDays(1)),
                GetDailyForecast(today.AddDays(2)),
                GetDailyForecast(today.AddDays(3)),
                GetDailyForecast(today.AddDays(4)),
                GetDailyForecast(today.AddDays(5)),
                GetDailyForecast(today.AddDays(6))
            };
        }

        [Route("summary")]
        [HttpGet()]
        public string Summary()
        {
            var forecast = GetDailyForecast(DateTime.Today);
            return $"{forecast.Date.DayOfWeek}: {forecast.TemperatureF} degrees F - {forecast.Summary}";
        }

        private WeatherForecast GetDailyForecast(DateTime date)
        {
            var random = new Random();
            var temp = random.Next(70) + -20;

            return new WeatherForecast
            {
                Date = date,
                TemperatureC = temp,
                Summary = temp switch
                {
                    < -20 => "Freezing",
                    < -10 => "Bracing",
                    < 0 => "Chilly",
                    < 10 => "Cool",
                    < 15 => "Mild",
                    < 20 => "Warm",
                    < 30 => "Balmy",
                    < 35 => "Hot",
                    < 40 => "Sweltering",
                    _ => "Scorching"
                }
            };
        }
    }
}
