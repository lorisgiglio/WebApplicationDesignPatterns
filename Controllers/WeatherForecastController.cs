using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Factories;
using WeatherForecast.Interfaces;

namespace WebApplication1.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            /* Abstract Factory - https://refactoring.guru/design-patterns/abstract-factory/csharp/example#lang-features 
               Abstract Factory is a creational design pattern, which solves the problem of creating entire product families 
               without specifying their concrete classes.
             */

            IWeatherForecastFactory localFactory = new LocalWeatherFactory();
            IWeatherForecastService localService = localFactory.CreateWeatherForecastService();
            Console.WriteLine(localService.GetWeatherReport());

            IWeatherForecastFactory globalFactory = new GlobalWeatherFactory();
            IWeatherForecastService globalService = globalFactory.CreateWeatherForecastService();
            Console.WriteLine(globalService.GetWeatherReport());



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        }
    }
}
