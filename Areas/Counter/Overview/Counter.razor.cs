using Fluxor;
using Fluxor.Blazor.Web.Middlewares.Routing;
using FluxorPoc.Areas.Counter.Shared.State;
using FluxorPoc.Areas.Counter.Shared.State.Actions;
using Microsoft.AspNetCore.Components;

namespace FluxorPoc.Areas.Counter.Overview;

public partial class Counter
{
    [Inject] public IState<CounterState> CounterState { get; set; }

    [Inject] public IDispatcher Dispatcher { get; set; }

    private Task IncrementCount()
    {
        Dispatcher.Dispatch(new IncrementCounterAction());

        return Task.CompletedTask;
    }

    private void GoToWeather()
    {
        Dispatcher.Dispatch(new GoAction("/weather"));
    }
}