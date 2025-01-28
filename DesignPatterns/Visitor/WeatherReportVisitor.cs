namespace WebApplication1.DesignPatterns.Visitor
{
    // Implementazione concreta del Visitor
    public class WeatherReportVisitor : IWeatherVisitor
    {
        public void Visit(WeatherForecast weatherForecast)
        {
            Console.WriteLine($"Date: {weatherForecast.Date.ToShortDateString()}");
            Console.WriteLine($"Temperature: {weatherForecast.TemperatureC}°C ({weatherForecast.TemperatureF}°F)");
            Console.WriteLine($"Summary: {weatherForecast.Summary}");
            Console.WriteLine();
        }
    }
}
