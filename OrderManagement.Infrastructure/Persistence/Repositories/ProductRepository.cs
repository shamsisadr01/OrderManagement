using Microsoft.EntityFrameworkCore;
using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrderManagementContext _context;

        public ProductRepository(OrderManagementContext context)
        {
            _context = context;
        }

        public async Task<Product?> GetByIdAsync(
            int id,
            CancellationToken cancellationToken = default)
        {
            return await _context.Products
                .Include(p => p.Inventory)
                .FirstOrDefaultAsync(
                    p => p.Id == id,
                    cancellationToken);
        }

        public async Task<IReadOnlyList<Product>> GetByIdsAsync(
            List<int> productIds,
            CancellationToken cancellationToken = default)
        {
            return await _context.Products
                .Include(p => p.Inventory).Where(p => productIds.Contains(p.Id)).ToListAsync(cancellationToken);
        }
    }
}
