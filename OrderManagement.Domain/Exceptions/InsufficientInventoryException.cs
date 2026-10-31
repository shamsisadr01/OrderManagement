namespace OrderManagement.Domain.Exceptions
{
    public class InsufficientInventoryException : DomainException
    {
        public InsufficientInventoryException(int productId, int requestedQuantity, int availableQuantity)
            : base($"Insufficient inventory for product {productId}. Requested: {requestedQuantity}, Available: {availableQuantity}.")
        {
        }
    }
}
