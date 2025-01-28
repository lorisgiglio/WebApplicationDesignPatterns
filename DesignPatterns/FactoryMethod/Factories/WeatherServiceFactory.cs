using WebApplication1.DesignPatterns.FactoryMethod.WeatherServices;

namespace WebApplication1.DesignPatterns.FactoryMethod.Factories
{
    public abstract class WeatherServiceFactory
    {
        public abstract IWeatherService CreateWeatherService();
    }
}
