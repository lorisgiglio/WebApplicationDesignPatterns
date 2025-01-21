using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Factories;
using WeatherForecast.Interfaces;
using WebApplication1.FactoryMethod.Factories;

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
            
            Console.WriteLine("--- ABSTRACT FACTORY PATTERN");

            IWeatherForecastFactory localFactory = new LocalWeatherFactory();
            IWeatherForecastService localService = localFactory.CreateWeatherForecastService();
            Console.WriteLine(localService.GetWeatherReport());

            IWeatherForecastFactory globalFactory = new GlobalWeatherFactory();
            IWeatherForecastService globalService = globalFactory.CreateWeatherForecastService();
            Console.WriteLine(globalService.GetWeatherReport());

            /*
               Factory Method - https://refactoring.guru/design-patterns/factory-method
               Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, 
               but allows subclasses to alter the type of objects that will be created.
             */

            Console.WriteLine("--- FACTORY METHOD PATTERN");
            Console.WriteLine("Select Weather Service: 1. OpenWeather 2. Weather.com");

            string choice = Console.ReadLine();

            WeatherServiceFactory factory = choice switch
            {
                "1" => new OpenWeatherServiceFactory(),
                "2" => new WeatherDotComServiceFactory(),
                _ => throw new ArgumentException("Invalid choice.")
            };

            var weatherService = factory.CreateWeatherService();

            Console.WriteLine("Enter a location:");
            string location = Console.ReadLine();

            Console.WriteLine(weatherService.GetWeatherReport(location));











            return null;

            /*
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            */
        }
    }
}
