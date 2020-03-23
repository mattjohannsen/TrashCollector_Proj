using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class customerdatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a414fb-c109-4da7-8a8a-d231d4be0d5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94529ac1-4ca7-41f5-90c5-eb016a8c2330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a08707d0-be59-4a88-827b-9f071f54ec66");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94529ac1-4ca7-41f5-90c5-eb016a8c2330", "45cf847a-65c1-49b3-ae24-6a21bbd81336", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a08707d0-be59-4a88-827b-9f071f54ec66", "6fe3978c-9317-40b0-b584-285c75a1085c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84a414fb-c109-4da7-8a8a-d231d4be0d5b", "8cd3c73f-a324-401f-8646-efbd45608694", "Customer", "CUSTOMER" });
        }
    }
}
