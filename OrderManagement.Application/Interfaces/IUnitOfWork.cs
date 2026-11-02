using System.Data.Common;

namespace OrderManagement.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(
            CancellationToken cancellationToken = default);

        Task ExecuteInTransactionAsync(
            Func<DbTransaction, CancellationToken, Task> operation,
            CancellationToken cancellationToken = default);
    }
}
