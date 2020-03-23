using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class employeezip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "410d983e-d19a-44e4-9748-454eaf7ace43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2d30292-6c0a-42f3-9283-427bf8f15184");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d19ef9b1-ce6b-4658-8102-835886df422b");

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0e7e6d4-5a5c-4541-9b66-a3d06e4b302d", "4bc70ce9-da87-469b-8586-86fd67edf66c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eabbe486-1318-4e78-bad7-6e863b1ee4ea", "b432d876-2bda-4849-b1d2-82f34083f055", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "833f4859-6914-4b34-b9fd-d15a8002586c", "31799d8f-0b21-40dd-ac50-596f227ba100", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "833f4859-6914-4b34-b9fd-d15a8002586c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0e7e6d4-5a5c-4541-9b66-a3d06e4b302d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eabbe486-1318-4e78-bad7-6e863b1ee4ea");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d19ef9b1-ce6b-4658-8102-835886df422b", "dd789241-a969-4322-96ce-5d7126dc0642", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2d30292-6c0a-42f3-9283-427bf8f15184", "b5bfd96f-7963-4d4a-a769-1f47eaea55cf", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "410d983e-d19a-44e4-9748-454eaf7ace43", "70ebacc6-355e-4814-a618-7cdb388cbdbe", "Customer", "CUSTOMER" });
        }
    }
}
