using WeatherForecast.Interfaces;
using WeatherForecast.Local;

namespace WeatherForecast.Factories
{
    public class LocalWeatherFactory : IWeatherForecastFactory
    {
        public IWeatherForecastService CreateWeatherForecastService()
        {
            return new LocalWeatherForecast();
        }
    }
}