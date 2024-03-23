using Fluxor;
using FluxorPoc.Areas.Weather.Shared.Services;
using FluxorPoc.Areas.Weather.Shared.State.Actions;

namespace FluxorPoc.Areas.Weather.Shared.State.Effects
{
    public class FetchForecastsActionEffect : Effect<FetchForecastsAction>
    {
        private readonly IWeatherDataService _dataService;

        public FetchForecastsActionEffect(IWeatherDataService dataService)
        {
            _dataService = dataService;
        }

        public override async Task HandleAsync(FetchForecastsAction action, IDispatcher dispatcher)
        {
            var forecasts = await _dataService.LoadForecastsAsync();
            dispatcher.Dispatch(new FetchForecastsActionSuccess(forecasts));
        }
    }
}
