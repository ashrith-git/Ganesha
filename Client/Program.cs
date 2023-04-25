using EPASBlazor.Client;
using EPASBlazor.Client.HttpRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("AppAPI", cl => 
{
    cl.BaseAddress = new Uri("https://localhost:7005/api/");
});

builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("AppAPI"));

builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTgzMzQwNEAzMjMxMmUzMTJlMzMzNUdicWJOUlpOOEpQdXc0NzFXaHU1cjdLMVlUTUJFL3A5ZUJ1ckFrOFNhQlk9");

await builder.Build().RunAsync();
