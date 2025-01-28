using WebApplication1.DesignPatterns.AbstractFactory.Global;
using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;

namespace WebApplication1.DesignPatterns.AbstractFactory.Factories
{
    public class GlobalWeatherFactory : IWeatherForecastFactory
    {
        public IWeatherForecastService CreateWeatherForecastService()
        {
            return new GlobalWeatherForecast();
        }
    }
}