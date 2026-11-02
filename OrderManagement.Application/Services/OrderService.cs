using Microsoft.Extensions.Logging;
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
        private readonly ILogger<OrderService> _logger;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IUnitOfWork unitOfWork, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<int> CreateAsync(
            CreateOrderRequest request,
            CancellationToken cancellationToken = default)
        {
            _logger.LogInformation(
             "Creating order for customer {CustomerId} with {ItemCount} items",
             request.CustomerId,
             request.Items.Count);

            var order = new Order(request.CustomerId);

            foreach (var item in request.Items)
            {
                var product = await _productRepository.GetByIdAsync(
                    item.ProductId, cancellationToken);

                if (product is null)
                {
                    _logger.LogWarning(
                      "Product {ProductId} not found while creating order for customer {CustomerId}",
                      item.ProductId,
                      request.CustomerId);

                    throw new ProductNotFoundException(
                        $"Product {item.ProductId} not found.");
                }

                product.Inventory.Decrease(item.Quantity);

                order.AddItem(product, item.Quantity);
            }

            await _orderRepository.AddAsync(order, cancellationToken);

            _logger.LogInformation(
            "Order {OrderId} created successfully for customer {CustomerId}",order.Id,request.CustomerId);

            return order.Id;
        }

        public async Task<OrderResponse?> GetByIdAsync(
            int id,
            CancellationToken cancellationToken = default)
        {
            var order = await _orderRepository.GetByIdAsync(id, true, cancellationToken);

            if (order is null)
            {
                _logger.LogWarning("Order {OrderId} not found", id);
                return null;
            }

            return MapToResponse(order);
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

            _logger.LogInformation(
            "Retrieved {OrderCount} orders for page {PageNumber}",
            orders.Count,
            pageNumber);

            return orders.Select(MapToResponse).ToList();
        }

        public async Task UpdateStatusAsync(int id, OrderStatus status, CancellationToken cancellationToken = default)
        {
            var order = await _orderRepository.GetByIdAsync(
                id, false, cancellationToken);

            if (order is null)
            {
                _logger.LogWarning( "Order {OrderId} not found while updating status",id);

                throw new OrderNotFoundException(
                    $"Order {id} not found.");
            }

            var oldStatus = order.Status;

            await _orderRepository.UpdateStatusAsync(
                order, status, cancellationToken);

            _logger.LogInformation(
            "Order {OrderId} status changed from {OldStatus} to {NewStatus}",
            id,
            oldStatus,
            status);
        }

        public async Task SoftDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Soft deleting order {OrderId}", id);

            await _orderRepository.SoftDeleteAsync(id, cancellationToken);

            _logger.LogInformation(
                "Order {OrderId} soft deleted successfully",
                id);
        }

        public async Task HardDeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            _logger.LogWarning(
                  "Hard deleting order {OrderId}",
                  id);

            await _orderRepository.HardDeleteAsync(id, cancellationToken);

            _logger.LogInformation(
                "Order {OrderId} permanently deleted",
                id);
        }

        public async Task AddRangeAsync(IEnumerable<CreateOrderRequest> orders, CancellationToken cancellationToken = default)
        {
            var requests = orders.ToList();

            if (requests.Count == 0)
            {
                _logger.LogWarning("Bulk order creation requested with an empty list");
                return;
            }

            _logger.LogInformation(
             "Starting bulk order creation for {OrderCount} orders",
             requests.Count);

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
                    {
                        _logger.LogWarning(
                          "Product {ProductId} not found during bulk order creation",
                          item.Key);
                        throw new ProductNotFoundException($"Product {item.Key} not found.");
                    }

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

                _logger.LogInformation(
                      "Bulk order creation completed for {OrderCount} orders and {ProductCount} products",
                      orderEntities.Count,
                      productIds.Count);

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
