namespace WebApplication1.DesignPatterns.FactoryMethod.WeatherServices
{
    public class OpenWeatherService : IWeatherService
    {
        public string GetWeatherReport(string location)
        {
            // Simulate fetching weather data from OpenWeather API.
            return $"OpenWeather: It's sunny in {location}.";
        }
    }
}
