using Lection0318Api2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lection0318API3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpDelete]
        public IActionResult DeleteSummary(int id)
        {
            if (id < 0)
                return BadRequest("id < 0");

            return StatusCode(418, "i'm teapot");

            return Ok(id);

            return Created();

            return NoContent();
        }
            
    }
}
