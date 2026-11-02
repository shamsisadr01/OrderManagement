using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Application.Dtos.Auth
{
    public class LoginRequest
    {
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }

    public class LoginResponse
    {
        public string AccessToken { get; set; } = null!;

        public string TokenType { get; set; } = "Bearer";

        public DateTime ExpiresAt { get; set; }
    }
}
