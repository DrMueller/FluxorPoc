using FluxorPoc.Areas.Weather.Shared.Dtos;

namespace FluxorPoc.Areas.Weather.Shared.Services.Implementation;

public class WeatherDataService : IWeatherDataService
{
    public Task<IReadOnlyCollection<WeatherforecastDto>> LoadForecastsAsync()
    {
        var result = new List<WeatherforecastDto>
        {
            new()
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                Summary = "Freezing",
                TemperatureC = -20
            },
            new()
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(50)),
                Summary = "Warm",
                TemperatureC = 15
            },
            new()
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)),
                Summary = "Hot",
                TemperatureC = 30
            }
        };

        return Task.FromResult<IReadOnlyCollection<WeatherforecastDto>>(result);
    }
}