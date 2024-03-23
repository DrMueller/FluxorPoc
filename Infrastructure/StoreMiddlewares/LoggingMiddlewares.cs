using Fluxor;

namespace FluxorPoc.Infrastructure.StoreMiddlewares
{
    public class LoggingMiddleware : Middleware
    {
        private IStore Store;

        public override Task InitializeAsync(IDispatcher dispatcher, IStore store)
        {
            Store = store;
            Console.WriteLine(nameof(InitializeAsync));
            
            return base.InitializeAsync(dispatcher, store);
        }
    }
}
