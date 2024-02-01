using System.Net;
using System.Text.Json;
using CleanArchitecture.Core;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.SimpleWeatherForecastProvider;

public static class ConfigureSimpleForecastProvider
{
    public static IServiceCollection AddSimpleForecastProvider(this IServiceCollection services) =>
        services
            .AddHttpClient<IWeatherConditionProvider, SimpleForecastProvider>(client =>
                client.BaseAddress = new Uri("http://bogus.org"))
            .ConfigurePrimaryHttpMessageHandler(() => new MockHttpMessageHandler())
            .Services;
}

internal class MockHttpMessageHandler : HttpMessageHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
        Task.FromResult(
            new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(JsonSerializer.Serialize(summaries))
            });

    private readonly string[] summaries =
        [
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        ];
}
