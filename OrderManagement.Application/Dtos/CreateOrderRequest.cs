namespace OrderManagement.Application.Dtos
{
    public class CreateOrderRequest
    {
        public int CustomerId { get; set; }

        public List<CreateOrderItemRequest> Items { get; set; } = [];
    }

    public class CreateOrderItemRequest
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }

    public class OrderResponse
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Status { get; set; }

        public decimal TotalAmount { get; set; }

        public List<OrderItemResponse> Items { get; set; } = [];
    }

    public class OrderItemResponse
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
