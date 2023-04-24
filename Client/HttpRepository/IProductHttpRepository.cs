using EPASBlazor.Shared;

namespace EPASBlazor.Client.HttpRepository
{
    public interface IProductHttpRepository
    {
        Task<List<Product>> GetProducts();
    }
}
