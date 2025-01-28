using WeatherForecast.Interfaces;

namespace WeatherForecast.Global
{
    public class GlobalWeatherForecast : IWeatherForecastService
    {
        public string GetWeatherReport()
        {
            return "Global Weather: Partly Cloudy, 20°C.";
        }
    }
}