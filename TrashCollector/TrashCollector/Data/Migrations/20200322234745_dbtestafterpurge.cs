using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class dbtestafterpurge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d93409-911b-43b0-961b-23d4444ab788");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41d5fc0d-fce7-41e2-ad32-cdf0ff2429d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee7c05f-f1d8-44b4-bd87-c397a51dcdec");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "41d5fc0d-fce7-41e2-ad32-cdf0ff2429d9", "e59aa2f2-173b-4659-9cd3-ada1e2bc55e1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ee7c05f-f1d8-44b4-bd87-c397a51dcdec", "efdcaa83-b80b-4f66-ba25-215dead9e117", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17d93409-911b-43b0-961b-23d4444ab788", "2043437b-44f5-4529-a462-e8d86aa1aec6", "Customer", "CUSTOMER" });
        }
    }
}
