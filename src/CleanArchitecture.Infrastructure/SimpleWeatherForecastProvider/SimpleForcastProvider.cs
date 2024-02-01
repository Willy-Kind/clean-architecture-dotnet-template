using System.Net.Http.Json;
using CleanArchitecture.Core;

namespace CleanArchitecture.Infrastructure.SimpleWeatherForecastProvider;

public class SimpleForecastProvider(HttpClient _client) : IWeatherConditionProvider
{
    public async Task<string[]> GetWeatherConditions()
    {
        var response = await _client.GetAsync("")!;
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<string[]>() ?? [];
    }
}
