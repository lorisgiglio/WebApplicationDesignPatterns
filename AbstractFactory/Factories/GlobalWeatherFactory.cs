using WeatherForecast.Global;
using WeatherForecast.Interfaces;

namespace WeatherForecast.Factories
{
    public class GlobalWeatherFactory : IWeatherForecastFactory
    {
        public IWeatherForecastService CreateWeatherForecastService()
        {
            return new GlobalWeatherForecast();
        }
    }
}