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
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
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
                id, true, cancellationToken);

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
                id, false, cancellationToken);

            if (order is null)
                throw new OrderNotFoundException(
                    $"Order {id} not found.");

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

        public async Task AddRangeAsync(IEnumerable<CreateOrderRequest> orders, CancellationToken cancellationToken = default)
        {
            var requests = orders.ToList();

            if (requests.Count == 0)
                return;

            await _unitOfWork.ExecuteInTransactionAsync(async (dbtrans, ct) =>
            {

                var productIds = requests
                .SelectMany(x => x.Items)
                .Select(x => x.ProductId)
                .Distinct()
                .ToList();

                var products = await _productRepository.GetByIdsAsync(productIds, ct);

                var productDictionary = products.ToDictionary(x => x.Id);


                var requiredQuantities = requests
                    .SelectMany(x => x.Items)
                    .GroupBy(x => x.ProductId)
                    .ToDictionary(
                      x => x.Key,
                      x => x.Sum(item => item.Quantity));

                // بررسی و کاهش موجودی
                foreach (var item in requiredQuantities)
                {
                    if (!productDictionary.TryGetValue(item.Key, out var product))
                        throw new ProductNotFoundException($"Product {item.Key} not found.");

                    product.Inventory.Decrease(item.Value);
                }

                // ساخت سفارش‌ها
                var orderEntities = new List<Order>();

                foreach (var request in requests)
                {
                    var order = new Order(request.CustomerId);

                    foreach (var item in request.Items)
                    {
                        var product = productDictionary[item.ProductId];
                        order.AddItem(product, item.Quantity);
                    }

                    orderEntities.Add(order);
                }

                await _orderRepository.AddRangeAsync(orderEntities, ct);

            }, cancellationToken);

        }

        private static OrderResponse MapToResponse(Order order)
        {
            return new OrderResponse
            {
                Id = order.Id,
                CustomerId = order.CustomerId,
                CreatedAt = order.CreatedAt,
                Status = order.Status.ToString(),
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
