using OrderManagement.Domain.Enums;
using OrderManagement.Domain.Exceptions;

namespace OrderManagement.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public OrderStatus Status { get; private set; }

        public bool IsDeleted { get; private set; }

        public DateTime? DeletedAt { get; private set; }

        private readonly List<OrderItem> _items = [];
        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

        public decimal TotalAmount => _items.Sum(x => x.TotalPrice);

        private Order()
        {

        }

        public Order(int customerId)
        {
            if (customerId <= 0)
                throw new ArgumentException("Customer ID must be greater than zero.");

            CustomerId = customerId;
            Status = OrderStatus.Pending;
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
            DeletedAt = null;
        }

        public void AddItem(Product product, int quantity)
        {
            if (IsDeleted)
                throw new InvalidOrderStateException("Cannot modify a deleted order.");

            if (Status != OrderStatus.Pending)
                throw new InvalidOrderStateException("Cannot modify an order that is not pending.");

            ArgumentNullException.ThrowIfNull(product);

            var item = new OrderItem(this, product, quantity);

            _items.Add(item);
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            if (IsDeleted)
                throw new InvalidOrderStateException("Cannot change the status of a deleted order.");

            if (Status == OrderStatus.Delivered ||
                newStatus != (OrderStatus)((int)Status + 1))
            {
                throw new InvalidOrderStatusException(Status, newStatus);
            }

            Status = newStatus;
        }

        public void SoftDelete()
        {
            if (IsDeleted)
                return;

            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }
    }
}
