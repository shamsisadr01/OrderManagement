using Microsoft.EntityFrameworkCore.Storage;
using OrderManagement.Application.Interfaces;
using System.Data.Common;

namespace OrderManagement.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderManagementContext _context;

        public UnitOfWork(OrderManagementContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task ExecuteInTransactionAsync(
            Func<DbTransaction, CancellationToken, Task> operation, CancellationToken cancellationToken = default)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync(cancellationToken);

            try
            {

                var dbTransaction = transaction.GetDbTransaction();

                await operation(dbTransaction, cancellationToken);

                await SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            }
            catch
            {
                await transaction.RollbackAsync(cancellationToken);

                throw;
            }
        }


    }
}
