using WebApplication1.FactoryMethod.WeatherServices;

namespace WebApplication1.FactoryMethod.Factories
{
    public abstract class WeatherServiceFactory
    {
        public abstract IWeatherService CreateWeatherService();
    }
}
