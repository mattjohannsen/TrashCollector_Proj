using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class nullableDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e22a080-4cdd-4142-ab5e-4566583284f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de386688-08c2-400e-a6c6-21b71f35d635");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd9583cf-7acb-4b90-9235-1c4494a1afb2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartSuspension",
                table: "Suspension",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndSuspension",
                table: "Suspension",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartSuspension",
                table: "Suspension",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndSuspension",
                table: "Suspension",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de386688-08c2-400e-a6c6-21b71f35d635", "ce05c17d-76cd-4d19-b35f-52635b79531f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e22a080-4cdd-4142-ab5e-4566583284f9", "47a95011-e04c-46b5-ad4c-742f13fa18ae", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd9583cf-7acb-4b90-9235-1c4494a1afb2", "84624039-7508-412a-850a-9dec7907b9a1", "Customer", "CUSTOMER" });
        }
    }
}
