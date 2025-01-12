using WeatherForecast.Factories;
using WeatherForecast.Interfaces;
using WeatherForecast.Local;

namespace WebApplication1.AbstractFactory.Local
{
    public class LocalWeatherFactory : IWeatherForecastFactory
    {
        public IWeatherForecastService CreateWeatherForecastService()
        {
            return new LocalWeatherForecast();
        }
    }
}
