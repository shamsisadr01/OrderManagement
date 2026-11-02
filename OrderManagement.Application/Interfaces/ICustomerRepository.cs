using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetByEmailAsync(string email,CancellationToken cancellationToken = default);
    }
}
