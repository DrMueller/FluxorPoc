using Fluxor;
using FluxorPoc.Areas.Counter.Shared.State.Actions;

namespace FluxorPoc.Areas.Counter.Shared.State
{
    public static class CounterStateReducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
            new(clickCount: state.ClickCount + 1);
    }
}
