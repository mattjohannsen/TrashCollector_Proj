using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class customerstart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "091c658e-2837-4413-b11f-22d50c51287f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37ca5928-4a33-4103-bbbb-03c57a477172");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88d6ae76-2f82-4296-a8f4-b5f83dcad3bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aca7fed8-7f09-46d9-be92-4f994eebdc79", "a6ed6d73-d632-4303-81d8-d260ba2ba665", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25d44791-5439-40e8-8f1d-e18ca59343e4", "12fc9eda-89ee-4f55-b6b2-272d3424c484", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d43b2d1-0dc0-481a-a85d-46f4eb06c28e", "9b5e0af5-b855-4650-8ae0-8f7921d5ebfc", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25d44791-5439-40e8-8f1d-e18ca59343e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d43b2d1-0dc0-481a-a85d-46f4eb06c28e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca7fed8-7f09-46d9-be92-4f994eebdc79");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88d6ae76-2f82-4296-a8f4-b5f83dcad3bb", "8364d4b3-9f5c-4197-8774-5961a719b0ed", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "091c658e-2837-4413-b11f-22d50c51287f", "494cbb59-bfd8-4c39-af75-57804c4871a5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37ca5928-4a33-4103-bbbb-03c57a477172", "2ff8b730-823c-4f68-a3b5-76e52d49f61e", "Customer", "CUSTOMER" });
        }
    }
}
