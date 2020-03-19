using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class pudaysbutnocustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4df3adc5-43d3-48ce-b8b6-3475d1979463");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2494363-78f5-4261-8c11-f7883c130a80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2b8aaa6-5f05-4fab-a5e7-5eee0d3d4be4");

            migrationBuilder.DropColumn(
                name: "PickupDayId",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "802124ec-6b00-4dd0-8d6d-710475793117", "773c8d21-887c-4ad5-afc2-ee1bf696c0e6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cbd1c84-d94b-4238-ab3c-6e00c09b9d0a", "d9b1d23c-b3ef-4b97-8156-6c79b9ff310a", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40a1adcc-bf41-41ce-8bfd-c1245e0c1107", "9328b13f-c1ac-4f21-bb0a-4171abb05238", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_WeeklyPickUp",
                table: "Customer",
                column: "WeeklyPickUp");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PickupDays_WeeklyPickUp",
                table: "Customer",
                column: "WeeklyPickUp",
                principalTable: "PickupDays",
                principalColumn: "PickupDayId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PickupDays_WeeklyPickUp",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_WeeklyPickUp",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40a1adcc-bf41-41ce-8bfd-c1245e0c1107");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cbd1c84-d94b-4238-ab3c-6e00c09b9d0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "802124ec-6b00-4dd0-8d6d-710475793117");

            migrationBuilder.AddColumn<string>(
                name: "PickupDayId",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4df3adc5-43d3-48ce-b8b6-3475d1979463", "bc765ecc-06fe-4cad-8e5c-d7ae1374d691", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2494363-78f5-4261-8c11-f7883c130a80", "7c169af6-ca09-4903-877f-e5f7c264060d", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2b8aaa6-5f05-4fab-a5e7-5eee0d3d4be4", "711a66ae-7ce3-4791-b218-38eb51dc2ec4", "Customer", "CUSTOMER" });
        }
    }
}
