using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedispickedup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6241f047-767e-4d08-80c2-c54d2ee70c16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64cc36e3-5bb9-4b6e-93fd-5f89102d4796");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a4e6c07-e2ab-4a9b-be24-55ff8a7115eb");

            migrationBuilder.AddColumn<bool>(
                name: "IsPickedup",
                table: "Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ad6c9e9-2ab7-45ba-861b-f81a00c56f9a", "c0bd5613-9b7d-491c-a284-a91ddcd0346e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f42913d8-4794-42de-9072-09288b37f14d", "100078b2-0427-4f8c-bb58-edf27f518bc7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "779c59a7-2468-463f-9ce5-2a4faa7fd379", "c5b5f9e0-ff52-4893-a774-8e8a6a7ed9ea", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ad6c9e9-2ab7-45ba-861b-f81a00c56f9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "779c59a7-2468-463f-9ce5-2a4faa7fd379");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f42913d8-4794-42de-9072-09288b37f14d");

            migrationBuilder.DropColumn(
                name: "IsPickedup",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a4e6c07-e2ab-4a9b-be24-55ff8a7115eb", "0dad13e4-8097-43ed-848b-8005cec706d5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6241f047-767e-4d08-80c2-c54d2ee70c16", "8664c8b8-1d5c-41de-951e-3d0fd397f817", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64cc36e3-5bb9-4b6e-93fd-5f89102d4796", "cc95b117-2898-4e4c-b539-63de3455cf6f", "Customer", "CUSTOMER" });
        }
    }
}
