using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;

namespace WebApplication1.DesignPatterns.AbstractFactory.Global
{
    public class GlobalWeatherForecast : IWeatherForecastService
    {
        public string GetWeatherReport()
        {
            return "Global Weather: Partly Cloudy, 20°C.";
        }
    }
}