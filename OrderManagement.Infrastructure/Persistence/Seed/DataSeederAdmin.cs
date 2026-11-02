using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Application.Interfaces;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Enums;

namespace OrderManagement.Infrastructure.Persistence.Seed
{
    public static class DataSeederAdmin
    {
        public static async Task SeedAsync(
            IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            var services = scope.ServiceProvider;

            var context = services
                .GetRequiredService<OrderManagementContext>();

            var passwordService = services
                .GetRequiredService<IPasswordService>();

            if (!await context.Customers.AnyAsync(
                x => x.Email == "admin@ordermanagement.com"))
            {
                var admin = new Customer(
                    "System",
                    "Admin",
                    "admin@ordermanagement.com",
                    passwordService.HashPassword("Admin@123456"),
                    UserRole.Admin);

                context.Customers.Add(admin);

                await context.SaveChangesAsync();
            }
        }
    }

}
