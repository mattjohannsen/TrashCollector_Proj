using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class employeezipnamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "833f4859-6914-4b34-b9fd-d15a8002586c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0e7e6d4-5a5c-4541-9b66-a3d06e4b302d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eabbe486-1318-4e78-bad7-6e863b1ee4ea");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "RouteZipcode",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d0f2246-c4ce-4d8e-a1e6-50dce77ff94a", "7a888e76-c2ac-437c-8471-07d88269fc5d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc017d0e-acc4-45a8-a387-52cb073bf8d6", "f562a829-71c2-4d37-8b2e-f6448e4f5edd", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "819ca762-73bb-4854-b885-001f7c896265", "077d6539-fd81-4ec9-9205-3e855be5c5ac", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d0f2246-c4ce-4d8e-a1e6-50dce77ff94a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "819ca762-73bb-4854-b885-001f7c896265");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc017d0e-acc4-45a8-a387-52cb073bf8d6");

            migrationBuilder.DropColumn(
                name: "RouteZipcode",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0e7e6d4-5a5c-4541-9b66-a3d06e4b302d", "4bc70ce9-da87-469b-8586-86fd67edf66c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eabbe486-1318-4e78-bad7-6e863b1ee4ea", "b432d876-2bda-4849-b1d2-82f34083f055", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "833f4859-6914-4b34-b9fd-d15a8002586c", "31799d8f-0b21-40dd-ac50-596f227ba100", "Customer", "CUSTOMER" });
        }
    }
}
