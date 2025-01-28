using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;
using WebApplication1.DesignPatterns.AbstractFactory.Local;

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