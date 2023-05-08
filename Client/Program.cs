using EPASBlazor.Client;
using EPASBlazor.Client.HttpRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTgzMzQwNEAzMjMxMmUzMTJlMzMzNUdicWJOUlpOOEpQdXc0NzFXaHU1cjdLMVlUTUJFL3A5ZUJ1ckFrOFNhQlk9");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTk2NDc2NEAzMjMxMmUzMTJlMzMzNVRkamNtbGJlVllLQ24vdW1uV2ZQeFlqTGdWcWMzSFVxdFA0a252bStRK2M9");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(cl => 
{
    cl.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

//builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("AppAPI"));
//builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
