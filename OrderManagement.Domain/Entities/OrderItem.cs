namespace OrderManagement.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int OrderId { get; private set; }

        public int ProductId { get; private set; }

        public int Quantity { get; private set; }

        public decimal UnitPrice { get; private set; }

        public decimal TotalPrice => Quantity * UnitPrice;

        public Order Order { get; private set; } = null!;
        public Product Product { get; private set; } = null!;

        private OrderItem()
        {

        }

        internal OrderItem(Order order, Product product, int quantity)
        {
            ArgumentNullException.ThrowIfNull(order);
            ArgumentNullException.ThrowIfNull(product);

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            Order = order;
            OrderId = order.Id;

            Product = product;
            ProductId = product.Id;

            Quantity = quantity;
            UnitPrice = product.Price;
        }
    }
}
