using OrderManagement.Application.Dtos.Auth;
using OrderManagement.Application.Interfaces;

namespace OrderManagement.Infrastructure.Security
{
    public class AuthService : IAuthService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IPasswordService _passwordService;
        private readonly IJwtTokenService _jwtTokenService;

        public AuthService(
            ICustomerRepository customerRepository,
            IPasswordService passwordService,
            IJwtTokenService jwtTokenService)
        {
            _customerRepository = customerRepository;
            _passwordService = passwordService;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request,
            CancellationToken cancellationToken = default)
        {
            var customer = await _customerRepository.GetByEmailAsync(
                request.Email,
                cancellationToken);

            if (customer is null ||
                !_passwordService.VerifyPassword(
                    customer.PasswordHash,
                    request.Password))
            {
                throw new UnauthorizedAccessException(
                    "Invalid email or password.");
            }

            var token = _jwtTokenService.GenerateToken(customer);

            return new LoginResponse
            {
                AccessToken = token,
                TokenType = "Bearer",
                ExpiresAt = DateTime.UtcNow.AddMinutes(60)
            };
        }
    }
}
