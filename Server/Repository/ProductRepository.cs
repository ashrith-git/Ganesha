using EPASBlazor.Server.Context;
using EPASBlazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace EPASBlazor.Server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts() => await _context.Products.ToListAsync();

        public async Task<Product> GetProduct(Guid id) =>
            await _context.Products.FirstOrDefaultAsync(p => p.Id.Equals(id));
    }
}
