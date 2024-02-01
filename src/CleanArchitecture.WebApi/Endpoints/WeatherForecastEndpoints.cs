using CleanArchitecture.Core;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CleanArchitecture.WebApi;

public static class WeatherForecastEndpoints
{
    public static void MapWeatherForecastEndpoints(this IEndpointRouteBuilder builder)
    {
        builder
            .MapGet("/weatherforecast/{amount}", GetWeatherForecast)
            .WithName("GetWeatherForecast")
            .WithOpenApi();
    }

    public static async Task<Results<Ok<WeatherForecast[]>, NotFound>> GetWeatherForecast(
        IWeatherForecastService _service, int amount
    )
    {
        var forecast = await _service.GetWeatherForecasts(amount);
        return forecast.Length > 0 ? TypedResults.Ok(forecast) : TypedResults.NotFound();
    }
}
