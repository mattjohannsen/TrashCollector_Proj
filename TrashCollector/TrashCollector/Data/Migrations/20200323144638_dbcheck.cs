using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class dbcheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
