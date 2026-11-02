using OrderManagement.Application.Dtos;
using OrderManagement.Domain.Enums;

namespace OrderManagement.Application.Interfaces
{
    public interface IOrderService
    {
        Task<int> CreateAsync(CreateOrderRequest request, CancellationToken cancellationToken = default);

        Task<OrderResponse?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<OrderResponse>> GetAllAsync(
            int? customerId,
            OrderStatus? status,
            DateTime? startDate,
            DateTime? endDate,
            int pageNumber,
            int pageSize,
            CancellationToken cancellationToken = default);

        // Bulk Insert - ایجاد چند سفارش به‌صورت گروهی
        Task AddRangeAsync(
            IEnumerable<CreateOrderRequest> orders,
            CancellationToken cancellationToken = default);

        Task UpdateStatusAsync(int id, OrderStatus status, CancellationToken cancellationToken = default);

        Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default);

        Task HardDeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
