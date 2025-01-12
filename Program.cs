using WeatherForecast.Factories;
using WeatherForecast.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/* Abstract Factory - https://refactoring.guru/design-patterns/abstract-factory/csharp/example#lang-features */

IWeatherForecastFactory localFactory = new LocalWeatherFactory();
IWeatherForecastService localService = localFactory.CreateWeatherForecastService();
Console.WriteLine(localService.GetWeatherReport());

IWeatherForecastFactory globalFactory = new GlobalWeatherFactory();
IWeatherForecastService globalService = globalFactory.CreateWeatherForecastService();
Console.WriteLine(globalService.GetWeatherReport());
