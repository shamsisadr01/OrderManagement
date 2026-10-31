using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Enums;

namespace OrderManagement.Application.Interfaces
{
    public interface IOrderRepository
    {
        //ایجاد سفارش جدید شامل چند محصول
        Task AddAsync(Order order, CancellationToken cancellationToken = default);

        //مشاهده جزئیات یک سفارش بر اساس شناسه
        Task<Order?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        //جستجو و فیلتر سفارشها 
        Task<IReadOnlyList<Order>> GetAllAsync(int? customerId, OrderStatus? status, DateTime? startDate,
            DateTime? endDate, int pageNumber, int pageSize, CancellationToken cancellationToken = default);

        //تغییر وضعیت سفارش با رعایت ترتیب مراحل → Shipped → Confirmed → Pending -> Delivered
        Task UpdateStatusAsync(Order order, OrderStatus status, CancellationToken cancellationToken = default);

        Task AddRangeAsync(IEnumerable<Order> orders, CancellationToken cancellationToken = default);

        Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default);

        Task HardDeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
