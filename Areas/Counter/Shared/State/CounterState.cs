using Fluxor;

namespace FluxorPoc.Areas.Counter.Shared.State;

[FeatureState]
public class CounterState
{
    private CounterState()
    {
    } // Required for creating initial state

    public CounterState(int clickCount)
    {
        ClickCount = clickCount;
    }

    public int ClickCount { get; }
}