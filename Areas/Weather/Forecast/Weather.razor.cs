using Fluxor;
using FluxorPoc.Areas.Weather.Shared.State;
using FluxorPoc.Areas.Weather.Shared.State.Actions;
using Microsoft.AspNetCore.Components;

namespace FluxorPoc.Areas.Weather.Forecast
{
    public partial class Weather
    {
        [Inject]
        private IState<WeatherState> WeatherState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Dispatcher.Dispatch(new FetchForecastsAction());
        }
    }
}
