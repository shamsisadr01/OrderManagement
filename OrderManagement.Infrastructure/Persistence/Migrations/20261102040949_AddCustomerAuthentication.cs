using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagement.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAuthentication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Customers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "YOUR_PREGENERATED_PASSWORD_HASH", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Customers");
        }
    }
}
