using CleanArchitecture.Core;
using CleanArchitecture.WebApi;
using Microsoft.AspNetCore.Http.HttpResults;
using NSubstitute;

namespace CleanArchitecture.Tests;

public class WeatherForecastEndpointsTests
{
    [Fact]
    public async void GetWeatherForecast_GetForecasts_ReturnsForecasts()
    {
        // Arrange
        var service = Substitute.For<IWeatherForecastService>();
        service
            .GetWeatherForecasts(1)
            .Returns(Task.FromResult(new[] { new WeatherForecast(DateOnly.MinValue, 1, "test") }));

        // Act
        var result = await WeatherForecastEndpoints.GetWeatherForecast(service, 1);

        // Then
        Assert.True(result.Result is Ok<WeatherForecast[]>);
        Assert.NotEmpty((result.Result as Ok<WeatherForecast[]>)!.Value!);
    }

    [Fact]
    public async void GetWeatherForecast_GetForecasts_ReturnsEmpty()
    {
        // Arrange
        var service = Substitute.For<IWeatherForecastService>();

        // Act
        var result = await WeatherForecastEndpoints.GetWeatherForecast(service, 1);

        // Then
        Assert.True(result.Result is NotFound);
    }
}
