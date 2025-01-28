using WebApplication1.DesignPatterns.FactoryMethod.WeatherServices;

namespace WebApplication1.DesignPatterns.FactoryMethod.Factories
{
    public class WeatherDotComServiceFactory : WeatherServiceFactory
    {
        public override IWeatherService CreateWeatherService()
        {
            return new WeatherDotComService();
        }
    }
}
