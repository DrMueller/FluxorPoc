using FluxorPoc.Areas.Weather.Shared.Dtos;

namespace FluxorPoc.Areas.Weather.Shared.State.Actions
{
    public class FetchForecastsActionSuccess
    {
        public IReadOnlyCollection<WeatherforecastDto> Data { get; }

        public FetchForecastsActionSuccess(IReadOnlyCollection<WeatherforecastDto> data)
        {
            Data = data;
        }
    }
}
