using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;

namespace WebApplication1.DesignPatterns.AbstractFactory.Local
{
    public class LocalWeatherForecast : IWeatherForecastService
    {
        public string GetWeatherReport()
        {
            return "Local Weather: Sunny, 25°C.";
        }
    }
}