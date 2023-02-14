using Employee.Core.Options;
using Employee.Business.Employee.Queries;
using Employee.Business.Employee.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Employee.API.Controllers
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
        private readonly IMediator _mediator;
        private readonly ConnectionStringOptions _connectionStringOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator,
            IOptions<ConnectionStringOptions> connectionStringOptions)
        {
            _logger = logger;
            _mediator = mediator;
            _connectionStringOptions = connectionStringOptions.Value;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<GetEmployeesResponse> Get()
        {
            var employeesResponse = await _mediator.Send(new GetEmployeesQuery());

            return employeesResponse;
        }

        [HttpPut(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Put()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{id:int}")]
        public IEnumerable<WeatherForecast> Get(int id)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Post()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

}