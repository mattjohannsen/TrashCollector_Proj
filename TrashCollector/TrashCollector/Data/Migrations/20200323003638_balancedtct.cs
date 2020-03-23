using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class balancedtct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19185e0d-10ee-484f-bbd6-1fb0e9d1a197");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b4d69c7-67d4-457b-9821-840367123226");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a578e4d3-386c-4256-8035-78a7fea2adfa");

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Customer",
                type: "money",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19185e0d-10ee-484f-bbd6-1fb0e9d1a197", "cb35b03a-4145-4fe1-95f8-a4dfe643329c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a578e4d3-386c-4256-8035-78a7fea2adfa", "bf870aaf-0ef9-4557-bfd9-f18076bd71ce", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b4d69c7-67d4-457b-9821-840367123226", "f8be3ac2-ec8c-4f1d-bfc7-2c8d636e0f6b", "Customer", "CUSTOMER" });
        }
    }
}
