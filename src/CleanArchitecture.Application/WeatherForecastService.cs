namespace CleanArchitecture.Core;

public class WeatherForecastService(IWeatherConditionProvider _provider) : IWeatherForecastService
{
    public async Task<WeatherForecast[]> GetWeatherForecasts(int amount)
    {
        var conditions = await _provider.GetWeatherConditions();

        return Enumerable
           .Range(1, amount)
           .Select(index => new WeatherForecast(
               DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
               Random.Shared.Next(-20, 55),
               conditions[Random.Shared.Next(conditions.Length)]
           ))
           .ToArray();
    }
}
