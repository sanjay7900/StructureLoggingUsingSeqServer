using Microsoft.AspNetCore.Mvc;

namespace StructureLoggingUsingSeqServer.Controllers
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
        [Route("Get")]
        public IActionResult Get(string data)
        {
            _logger.LogInformation($"Info : Sanjay {data}");
            throw new NotImplementedException("Hi Sanjay singh i m Seq server ok...");    
        }
    }
}
