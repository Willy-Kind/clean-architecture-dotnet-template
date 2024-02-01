using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure.SimpleWeatherForecastProvider;
using CleanArchitecture.WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplicationServices()
    .AddSimpleForecastProvider()
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapWeatherForecastEndpoints();

app.Run();
