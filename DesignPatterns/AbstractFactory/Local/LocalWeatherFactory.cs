using WebApplication1.DesignPatterns.AbstractFactory.Factories;
using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;

namespace WebApplication1.DesignPatterns.AbstractFactory.Local
{
    public class LocalWeatherFactory : IWeatherForecastFactory
    {
        public IWeatherForecastService CreateWeatherForecastService()
        {
            return new LocalWeatherForecast();
        }
    }
}
