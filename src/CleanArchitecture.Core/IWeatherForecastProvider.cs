namespace CleanArchitecture.Core;

public interface IWeatherConditionProvider
{
    Task<string[]> GetWeatherConditions();
}
