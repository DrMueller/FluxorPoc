using Fluxor;
using FluxorPoc;
using FluxorPoc.Areas.Weather.Shared.Services;
using FluxorPoc.Areas.Weather.Shared.Services.Implementation;
using FluxorPoc.Infrastructure.StoreMiddlewares;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IWeatherDataService, WeatherDataService>();

var currentAssembly = typeof(Program).Assembly;
builder.Services.AddFluxor(options => options.ScanAssemblies(currentAssembly)
    .AddMiddleware<LoggingMiddleware>()
    .UseRouting()
    .UseReduxDevTools());


await builder.Build().RunAsync();