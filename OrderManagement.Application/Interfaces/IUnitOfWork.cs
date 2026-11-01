using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(
            CancellationToken cancellationToken = default);

        Task ExecuteInTransactionAsync(
            Func<CancellationToken, Task> operation,
            CancellationToken cancellationToken = default);
    }
}
