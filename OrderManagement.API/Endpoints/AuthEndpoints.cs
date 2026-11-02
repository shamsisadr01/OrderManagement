
using OrderManagement.Application.Dtos.Auth;
using OrderManagement.Application.Interfaces;

namespace OrderManagement.API.Endpoints
{
    public static class AuthEndpoints
    {
        public static IEndpointRouteBuilder MapAuthEndpoints(
            this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/api/auth")
                .WithTags("Authentication");

            group.MapPost("/login", async (
                LoginRequest request,
                IAuthService authService,
                CancellationToken cancellationToken) =>
            {
                try
                {
                    var response = await authService.LoginAsync(
                        request,
                        cancellationToken);

                    return Results.Ok(response);
                }
                catch (UnauthorizedAccessException ex)
                {
                    return Results.Unauthorized();
                }
            })
            .AllowAnonymous()
            .WithName("Login");

            group.MapGet("/me", (HttpContext context) =>
            {
                var userId = context.User.FindFirst(
                    System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

                var email = context.User.FindFirst(
                    System.Security.Claims.ClaimTypes.Email)?.Value;

                var role = context.User.FindFirst(
                    System.Security.Claims.ClaimTypes.Role)?.Value;

                return Results.Ok(new
                {
                    Id = userId,
                    Email = email,
                    Role = role
                });
            })
            .RequireAuthorization()
            .WithName("GetCurrentUser");

            return app;
        }
    }
}
