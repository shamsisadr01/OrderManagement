using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Exceptions
{
    public class InvalidOrderStateException : DomainException
    {
        public InvalidOrderStateException(string message)
            : base(message)
        {
        }
    }
}
