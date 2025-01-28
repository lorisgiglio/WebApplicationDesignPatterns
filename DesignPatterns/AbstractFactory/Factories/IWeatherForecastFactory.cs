using WeatherForecast.Interfaces;

namespace WeatherForecast.Factories
{
    public interface IWeatherForecastFactory
    {
        IWeatherForecastService CreateWeatherForecastService();
    }
}