using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hello_beanstalk.Controllers
{
    [ApiController]
    [Route("")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "WeatherForecast service OK";
        }
    }
}
