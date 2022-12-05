using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise;
using Blazorise.AntDesign;
using Blazorise.Icons.FontAwesome;
using PokeSharp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorise(options => { options.Immediate = true; })
    .AddAntDesignProviders()
    .AddFontAwesomeIcons();

builder.Services.AddScoped(sp => new HttpClient
    { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
