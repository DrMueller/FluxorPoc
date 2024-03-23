using FluxorPoc.Areas.Weather.Shared.Dtos;

namespace FluxorPoc.Areas.Weather.Shared.Services
{
    public interface IWeatherDataService
    {
        Task<IReadOnlyCollection<WeatherforecastDto>> LoadForecastsAsync();
    }
}
