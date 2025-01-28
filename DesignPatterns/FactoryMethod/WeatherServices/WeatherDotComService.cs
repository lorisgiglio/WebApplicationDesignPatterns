namespace WebApplication1.DesignPatterns.FactoryMethod.WeatherServices
{
    public class WeatherDotComService : IWeatherService
    {
        public string GetWeatherReport(string location)
        {
            // Simulate fetching weather data from Weather.com API.
            return $"Weather.com: It's cloudy in {location}.";
        }
    }
}
