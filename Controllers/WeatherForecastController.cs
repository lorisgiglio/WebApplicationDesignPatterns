using Microsoft.AspNetCore.Mvc;
using WebApplication1.DesignPatterns.AbstractFactory.Factories;
using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;
using WebApplication1.DesignPatterns.FactoryMethod.Factories;
using WebApplication1.DesignPatterns.Visitor;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
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

            string choice = Console.ReadLine()!;

            WeatherServiceFactory factory = choice switch
            {
                "1" => new OpenWeatherServiceFactory(),
                "2" => new WeatherDotComServiceFactory(),
                _ => throw new ArgumentException("Invalid choice.")
            };

            var weatherService = factory.CreateWeatherService();

            Console.WriteLine("Enter a location:");
            string location = Console.ReadLine()!;

            Console.WriteLine(weatherService.GetWeatherReport(location));




            /*
               Visitor - https://refactoring.guru/design-patterns/visitor
               Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.
             */


            // Creazione di una lista di WeatherForecast

            Console.WriteLine("--- VISITOR PATTERN");
            var forecasts = new List<WeatherForecast>
        {
            new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 25,
                Summary = "Sunny"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = 18,
                Summary = "Cloudy"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(2),
                TemperatureC = 30,
                Summary = "Hot"
            }
        };

            // Creazione del Visitor
            IWeatherVisitor visitor = new WeatherReportVisitor();

            // Applicazione del Visitor a ciascun oggetto WeatherForecast
            foreach (var forecast in forecasts)
            {
                forecast.Accept(visitor);
            }



            return null!;

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
