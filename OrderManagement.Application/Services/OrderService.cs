using OrderManagement.Application.Dtos;
using OrderManagement.Application.Exceptions;
using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Enums;

namespace OrderManagement.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public async Task<int> CreateAsync(
            CreateOrderRequest request,
            CancellationToken cancellationToken = default)
        {
            var order = new Order(request.CustomerId);

            foreach (var item in request.Items)
            {
                var product = await _productRepository.GetByIdAsync(
                    item.ProductId, cancellationToken);

                if (product is null)
                    throw new ProductNotFoundException(
                        $"Product {item.ProductId} not found.");

                product.Inventory.Decrease(item.Quantity);

                order.AddItem(product, item.Quantity);
            }

            await _orderRepository.AddAsync(order, cancellationToken);

            return order.Id;
        }

        public async Task<OrderResponse?> GetByIdAsync(
            int id,
            CancellationToken cancellationToken = default)
        {
            var order = await _orderRepository.GetByIdAsync(
                id, cancellationToken);

            return order is null ? null : MapToResponse(order);
        }

        public async Task<IReadOnlyList<OrderResponse>> GetAllAsync(
            int? customerId,
            OrderStatus? status,
            DateTime? startDate,
            DateTime? endDate,
            int pageNumber,
            int pageSize,
            CancellationToken cancellationToken = default)
        {
            var orders = await _orderRepository.GetAllAsync(
                customerId,
                status,
                startDate,
                endDate,
                pageNumber,
                pageSize,
                cancellationToken);

            return orders.Select(MapToResponse).ToList();
        }

        public async Task UpdateStatusAsync(int id, OrderStatus status, CancellationToken cancellationToken = default)
        {
            var order = await _orderRepository.GetByIdAsync(
                id, cancellationToken);

            if (order is null)
                throw new OrderNotFoundException(
                    $"Order {id} not found.");

            order.ChangeStatus(status);

            await _orderRepository.UpdateStatusAsync(
                order, status, cancellationToken);
        }

        public Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            return _orderRepository.SoftDeleteAsync(id, cancellationToken);
        }

        public Task HardDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            return _orderRepository.HardDeleteAsync(id, cancellationToken);
        }

        private static OrderResponse MapToResponse(Order order)
        {
            return new OrderResponse
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                CreatedAt = order.CreatedAt,
                Status = order.Status,
                TotalAmount = order.TotalAmount,

                Items = order.Items.Select(item => new OrderItemResponse
                {
                    ProductId = item.ProductId,
                    ProductName = item.Product.Name,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    TotalPrice = item.TotalPrice
                }).ToList()
            };
        }
    }
}
