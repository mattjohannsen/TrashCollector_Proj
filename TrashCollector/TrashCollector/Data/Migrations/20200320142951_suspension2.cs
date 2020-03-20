using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class suspension2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Suspension",
                columns: table => new
                {
                    SuspensionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    StartSuspension = table.Column<DateTime>(nullable: false),
                    EndSuspension = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspension", x => x.SuspensionId);
                    table.ForeignKey(
                        name: "FK_Suspension_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Suspension_CustomerId",
                table: "Suspension",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suspension");

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
    }
}
