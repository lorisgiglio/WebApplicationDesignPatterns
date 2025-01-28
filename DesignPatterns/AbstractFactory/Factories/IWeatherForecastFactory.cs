using WebApplication1.DesignPatterns.AbstractFactory.Interfaces;

namespace WebApplication1.DesignPatterns.AbstractFactory.Factories
{
    public interface IWeatherForecastFactory
    {
        IWeatherForecastService CreateWeatherForecastService();
    }
}