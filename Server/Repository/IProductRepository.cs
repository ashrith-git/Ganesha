using EPASBlazor.Shared;

namespace EPASBlazor.Server.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(Guid id);
    }
}
