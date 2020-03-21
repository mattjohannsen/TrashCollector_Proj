using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class startendhold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9668ed4d-37e9-49fa-9615-f2c5a4f90411");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8aa9f64-385b-4aa1-9e96-7227fb5e033d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f77a1592-6308-4eb2-95d1-5a7b742c352f");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndHold",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartHold",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "077f3ef7-d2c6-4f6c-82db-76b0f3268646", "0c0d7bcb-81ee-48ad-80d4-5d3a3efd54a3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b7ba4a2-01c9-402e-92f3-645991203d62", "a44025a8-0834-421c-8b7f-24ee0565c65c", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8576f22-1d72-40e6-9103-5d56f0c81a5b", "16a54676-a80d-419d-baef-e148ac3c954b", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "077f3ef7-d2c6-4f6c-82db-76b0f3268646");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b7ba4a2-01c9-402e-92f3-645991203d62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8576f22-1d72-40e6-9103-5d56f0c81a5b");

            migrationBuilder.DropColumn(
                name: "EndHold",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StartHold",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9668ed4d-37e9-49fa-9615-f2c5a4f90411", "09dd65a4-59e8-4d7e-9173-8e8a0d5de331", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8aa9f64-385b-4aa1-9e96-7227fb5e033d", "d197cc0e-464d-4314-970e-8f215552bec9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f77a1592-6308-4eb2-95d1-5a7b742c352f", "5d6e9257-cf0d-4274-9134-4c43d503a345", "Customer", "CUSTOMER" });
        }
    }
}
