using WebApplication1.DesignPatterns.FactoryMethod.WeatherServices;

namespace WebApplication1.DesignPatterns.FactoryMethod.Factories
{
    public class OpenWeatherServiceFactory : WeatherServiceFactory
    {
        public override IWeatherService CreateWeatherService()
        {
            return new OpenWeatherService();
        }
    }
}
