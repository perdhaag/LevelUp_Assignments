using System.Diagnostics.Tracing;
using DjHaag.Web.Data;

namespace DjHaag.Tests;

public class UnitTest1
{
    [Fact]
    public async Task WeatherForcastServiceTest()
    {
        string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        WeatherForecastService service = new();

        var forecasts = await service.GetForecastAsync(new DateTime());
        var expectedSize = forecasts.Length;
        
        Assert.Equal(5, expectedSize);
    }
}