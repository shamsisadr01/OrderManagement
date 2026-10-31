using OrderManagement.Domain.Enums;

namespace OrderManagement.Domain.Exceptions
{
    public class InvalidOrderStatusException : DomainException
    {
        public InvalidOrderStatusException(OrderStatus currentStatus, OrderStatus requestedStatus)
            : base($"Cannot change order status from {currentStatus} to {requestedStatus}.")
        {
        }
    }
}
