using OrderManagement.Application.Dtos;
using OrderManagement.Application.Services;
using OrderManagement.Domain.Enums;

namespace OrderManagement.API.Endpoints
{

    public static class OrderEndpoints
    {
        public static IEndpointRouteBuilder MapOrderEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/orders").WithTags("Orders");

            // Create Order
            group.MapPost("/", async (
                CreateOrderRequest request,IOrderService orderService,
                CancellationToken cancellationToken) =>
            {
                var id = await orderService.CreateAsync(
                    request, cancellationToken);

                return Results.Created($"/api/orders/{id}", new { id });
            });

            // Get Order By Id
            group.MapGet("/{id:int}", async (
                int id,IOrderService orderService, 
                CancellationToken cancellationToken) =>
            {
                var order = await orderService.GetByIdAsync(
                    id, cancellationToken);

                return order is null? Results.NotFound(): Results.Ok(order);
            });

            // Get All Orders
            group.MapGet("/", async (
                int? customerId,
                OrderStatus? status,
                DateTime? startDate,
                DateTime? endDate,
                int pageNumber,
                int pageSize,
                IOrderService orderService,
                CancellationToken cancellationToken) =>
            {
                var orders = await orderService.GetAllAsync(
                    customerId,
                    status,
                    startDate,
                    endDate,
                    pageNumber,
                    pageSize,
                    cancellationToken);

                return Results.Ok(orders);
            });

            // Update Order Status
            group.MapPatch("/{id:int}/status", async (
                int id,
                OrderStatus status,
                IOrderService orderService,
                CancellationToken cancellationToken) =>
            {
                await orderService.UpdateStatusAsync(
                    id, status, cancellationToken);

                return Results.NoContent();
            });

            // Soft Delete
            group.MapDelete("/{id:int}", async (
                int id,
                IOrderService orderService,
                CancellationToken cancellationToken) =>
            {
                await orderService.SoftDeleteAsync(
                    id, cancellationToken);

                return Results.NoContent();
            });

            // Hard Delete
            group.MapDelete("/{id:int}/permanent", async (
                int id,
                IOrderService orderService,
                CancellationToken cancellationToken) =>
            {
                await orderService.HardDeleteAsync(
                    id, cancellationToken);

                return Results.NoContent();
            });

            return app;
        }
    }

}
