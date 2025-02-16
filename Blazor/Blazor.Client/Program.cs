using Blazor.Monaco;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.Interfaces;
using Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<IDataFileService, DataFileClientService>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddBlazorMonacoComponents();

var host = builder.Build();
var logger = host.Services.GetRequiredService<ILoggerFactory>()
    .CreateLogger<Program>();
logger.LogInformation("Editor is loading now");

await host.RunAsync();