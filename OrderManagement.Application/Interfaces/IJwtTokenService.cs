using OrderManagement.Application.Dtos.Auth;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Application.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateToken(Customer customer);
    }

    public interface IAuthService
    {
        Task<LoginResponse> LoginAsync(
            LoginRequest request,
            CancellationToken cancellationToken = default);
    }

    public interface IPasswordService
    {
        string HashPassword(string password);

        bool VerifyPassword(string passwordHash, string password);
    }
}
