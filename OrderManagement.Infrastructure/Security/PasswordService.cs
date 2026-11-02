using Microsoft.AspNetCore.Identity;
using OrderManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Infrastructure.Security
{
    public class PasswordService : IPasswordService
    {
        private readonly PasswordHasher<object> _hasher = new();

        public string HashPassword(string password)
        {
            return _hasher.HashPassword(new object(), password);
        }

        public bool VerifyPassword(
            string passwordHash,
            string password)
        {
            var result = _hasher.VerifyHashedPassword(
                new object(),
                passwordHash,
                password);

            return result != PasswordVerificationResult.Failed;
        }
    }
}
