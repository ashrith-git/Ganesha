using EPASBlazor.Client;
using EPASBlazor.Client.HttpRepository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("ProductsAPI", cl => 
{
    cl.BaseAddress = new Uri("https://localhost:7005/api/");
});

builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("ProductsAPI"));

builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();

await builder.Build().RunAsync();
