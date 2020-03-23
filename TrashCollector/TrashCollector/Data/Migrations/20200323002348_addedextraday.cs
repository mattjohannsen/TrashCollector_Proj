using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedextraday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtraPickupDay",
                table: "Customer",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ExtraPickupDay",
                table: "Customer");

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
    }
}
