namespace CleanArchitecture.Core;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetWeatherForecasts(int amount);
}