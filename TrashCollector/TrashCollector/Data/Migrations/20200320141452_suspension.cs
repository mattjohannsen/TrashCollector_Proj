using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class suspension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0deecf8c-4a05-4513-8629-46c510036589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e6f4435-67d0-4bb3-bd28-3cdfb47b0036");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddca07ba-be3d-4b66-beb5-6a49869f3f40");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81a8ddcd-af67-4478-82b4-209f3d32f1cb", "eecfb5a3-4c91-4986-b638-efda82b7f6c7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba480be5-f7b0-4112-ba7a-dc6d385f0d9e", "2dfb90d1-4a5b-431a-8925-795e395ccea9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "541ee871-9a2c-4186-887a-1ffed1499e18", "cec9c1fa-d844-4559-a9dc-9cf5a1ece02c", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "541ee871-9a2c-4186-887a-1ffed1499e18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81a8ddcd-af67-4478-82b4-209f3d32f1cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba480be5-f7b0-4112-ba7a-dc6d385f0d9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ddca07ba-be3d-4b66-beb5-6a49869f3f40", "396bd327-f530-4165-9135-106e961b2447", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0deecf8c-4a05-4513-8629-46c510036589", "f77271ab-6216-49f6-a28f-ca382c064e27", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e6f4435-67d0-4bb3-bd28-3cdfb47b0036", "3fcdd343-2d2f-4d2c-bbc5-647c7391b8cd", "Customer", "CUSTOMER" });
        }
    }
}
