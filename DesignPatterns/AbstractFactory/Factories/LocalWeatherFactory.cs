using WeatherForecast.Local;
using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;

namespace WebApplication1.DesignPatterns.AbstractFactory.Factories
{
    public class LocalWeatherFactory : IWeatherForecastFactory
    {
        public IWeatherForecastService CreateWeatherForecastService()
        {
            return new LocalWeatherForecast();
        }
    }
}