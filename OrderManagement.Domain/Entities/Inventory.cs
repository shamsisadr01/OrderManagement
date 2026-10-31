using OrderManagement.Domain.Exceptions;

namespace OrderManagement.Domain.Entities
{
    public class Inventory : BaseEntity
    {
        public int ProductId { get; private set; }

        public int Quantity { get; private set; }

        public Product Product { get; private set; } = null!;

        private Inventory()
        {

        }

        public Inventory(int quantity)
        {
            if (quantity < 0)
                throw new ArgumentException("Inventory quantity cannot be negative.");

            Quantity = quantity;
        }

        public void Decrease(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (Quantity < quantity)
            {
                throw new InsufficientInventoryException(ProductId,quantity,Quantity);
            }

            Quantity -= quantity;
        }

        public void Increase(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            Quantity += quantity;
        }
    }
}
