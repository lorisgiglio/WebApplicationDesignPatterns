namespace WebApplication1.DesignPatterns.Visitor
{
    using System;
    using System.Collections.Generic;

    // Interfaccia del Visitor
    public interface IWeatherVisitor
    {
        void Visit(WeatherForecast weatherForecast);
    }
}
