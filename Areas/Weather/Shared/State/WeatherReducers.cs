using Fluxor;
using FluxorPoc.Areas.Weather.Shared.State.Actions;

namespace FluxorPoc.Areas.Weather.Shared.State
{
    public static class WeatherReducers
    {
        [ReducerMethod]
        public static WeatherState ReduceFetchDataAction(WeatherState state, FetchForecastsAction action) =>
            new WeatherState(
                isLoading: true,
                forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceFetchDataResultAction(
            WeatherState state, FetchForecastsActionSuccess action) =>
            new WeatherState(
                isLoading: false,
                forecasts: action.Data);
    }
}
