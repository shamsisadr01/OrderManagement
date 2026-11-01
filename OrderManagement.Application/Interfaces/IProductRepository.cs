using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<Product>> GetByIdsAsync(List<int> productIds, CancellationToken cancellationToken = default);
    }
}
