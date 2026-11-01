using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Enums;

namespace OrderManagement.Infrastructure.Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderManagementContext _context;

        public OrderRepository(OrderManagementContext context)
        {
            _context = context;
        }

        // ایجاد سفارش جدید
        public async Task AddAsync(Order order, CancellationToken cancellationToken = default)
        {
            await _context.Orders.AddAsync(order, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        // مشاهده جزئیات سفارش
        public async Task<Order?> GetByIdAsync(
        int id,
        bool asNoTracking = true,
        CancellationToken cancellationToken = default)
        {
            var query = _context.Orders
                .Where(x => x.Id == id && !x.IsDeleted);

            if (asNoTracking)
            {
                query = query.AsNoTracking()
                    .Include(x => x.Items)
                    .ThenInclude(x => x.Product);
            }

            return await query.FirstOrDefaultAsync(cancellationToken);
        }

        // جستجو و فیلتر سفارش‌ها
        public async Task<IReadOnlyList<Order>> GetAllAsync(
            int? customerId,
            OrderStatus? status,
            DateTime? startDate,
            DateTime? endDate,
            int pageNumber,
            int pageSize,
            CancellationToken cancellationToken = default)
        {
            var query = _context.Orders
                .AsNoTracking()
                .Where(x => !x.IsDeleted);

            if (customerId.HasValue)
                query = query.Where(x => x.CustomerId == customerId.Value);

            if (status.HasValue)
                query = query.Where(x => x.Status == status.Value);

            if (startDate.HasValue)
                query = query.Where(x => x.CreatedAt >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(x => x.CreatedAt <= endDate.Value);

            return await query
                .OrderByDescending(x => x.CreatedAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(cancellationToken);
        }

        // تغییر وضعیت سفارش
        public async Task UpdateStatusAsync(Order order, OrderStatus status, CancellationToken cancellationToken = default)
        {
            order.ChangeStatus(status);
            await _context.SaveChangesAsync(cancellationToken);
        }

        // ثبت گروهی سفارش‌ها
        //public async Task AddRangeAsync(IEnumerable<Order> orders, CancellationToken cancellationToken = default)
        //{
        //    await _context.BulkInsertAsync(orders, cancellationToken: cancellationToken);
        //}
        public async Task AddRangeAsync(IEnumerable<Order> orders, CancellationToken cancellationToken = default)
        {
            await _context.Orders.AddRangeAsync(orders, cancellationToken);
        }


        // حذف نرم
        public async Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var order = await _context.Orders
                .FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted,
                    cancellationToken);

            if (order is null)
                return;

            order.SoftDelete();

            await _context.SaveChangesAsync(cancellationToken);
        }

        // حذف فیزیکی
        public async Task HardDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var order = await _context.Orders
                .FirstOrDefaultAsync(x => x.Id == id,
                    cancellationToken);

            if (order is null)
                return;

            _context.Orders.Remove(order);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
