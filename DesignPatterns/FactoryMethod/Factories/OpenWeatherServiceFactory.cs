using WebApplication1.FactoryMethod.WeatherServices;

namespace WebApplication1.FactoryMethod.Factories
{
    public class OpenWeatherServiceFactory : WeatherServiceFactory
    {
        public override IWeatherService CreateWeatherService()
        {
            return new OpenWeatherService();
        }
    }
}
