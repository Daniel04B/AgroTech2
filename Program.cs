using AgroTech;
using AgroTech.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder =
    WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>(
    "head::after");

// API
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress =
            new Uri("https://localhost:7096/")
    });

// SERVICIOS
builder.Services.AddScoped<AgricultorService>();

builder.Services.AddScoped<ZonaService>();

builder.Services.AddScoped<LecturaService>();

builder.Services.AddScoped<SensorService>();

await builder.Build().RunAsync();