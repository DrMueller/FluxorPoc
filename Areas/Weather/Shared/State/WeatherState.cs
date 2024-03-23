using Fluxor;
using FluxorPoc.Areas.Weather.Shared.Dtos;

namespace FluxorPoc.Areas.Weather.Shared.State;

[FeatureState]
public class WeatherState
{
    private WeatherState()
    {
    }

    public WeatherState(bool isLoading, IEnumerable<WeatherforecastDto> forecasts)
    {
        IsLoading = isLoading;
        Forecasts = forecasts ?? Array.Empty<WeatherforecastDto>();
    }

    public bool IsLoading { get; }
    public IEnumerable<WeatherforecastDto> Forecasts { get; }
}