namespace WebApplication1.DesignPatterns.Visitor
{
    // Estensione della classe WeatherForecast per accettare un Visitor
    public static class WeatherForecastExtensions
    {
        public static void Accept(this WeatherForecast weatherForecast, IWeatherVisitor visitor)
        {
            visitor.Visit(weatherForecast);
        }
    }
}
