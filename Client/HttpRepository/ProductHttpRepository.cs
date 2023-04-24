using EPASBlazor.Shared;
using System.Net.Http.Json;

namespace EPASBlazor.Client.HttpRepository
{
    public class ProductHttpRepository : IProductHttpRepository
    {
        private readonly HttpClient _client;
        public ProductHttpRepository(HttpClient client)
        {
           _client = client;
        }
        public async Task<List<Product>> GetProducts()
        {
            var products = await _client.GetFromJsonAsync<List<Product>>("products");
            return products;
        }
    }
}
