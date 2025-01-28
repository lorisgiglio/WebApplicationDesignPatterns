using WeatherForecast.Interfaces;

namespace WeatherForecast.Local
{
    public class LocalWeatherForecast : IWeatherForecastService
    {
        public string GetWeatherReport()
        {
            return "Local Weather: Sunny, 25°C.";
        }
    }
}