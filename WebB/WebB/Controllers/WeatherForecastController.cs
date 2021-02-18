using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.OData;

namespace WebB.Controllers
{
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
        [Route("api/GetForecasts()")]
        public IEnumerable<WeatherForecast> GetForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPut]
        [Route("api/Demo()")]
        public ODataActionParameters Demo([FromBody] ODataActionParameters content)
        {
            return content;
        }

        [HttpPost]
        [Route("api/DemoDemo()")]
        public ODataActionParameters DemoDemo([FromBody] ODataActionParameters content)
        {
            return content;
        }

        [HttpGet]
        [Route("api/DemoGet()")]
        public string DemoGet()
        {
            return "Getttttt";
        }

        [HttpDelete]
        [Route("api/DemoDelete()")]
        public string DemoDelete()
        {
            return "DemoDeleteDemoDeleteDemoDeleteDemoDeleteDemoDeleteDemoDelete";
        }
    }
}
