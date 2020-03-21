using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class nulldate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartHold",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndHold",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartHold",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndHold",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

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
    }
}
