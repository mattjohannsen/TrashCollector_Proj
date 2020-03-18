using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class newIdentityRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5139881b-d1fb-4931-8194-6c8ab40c0708");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a00dace-0d0b-4188-8080-930e3f547023", "ffa9ad7c-cd16-467a-8b44-dfc4518757ff", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe9d575d-dc19-4d11-9fbe-7cbad81c2dd6", "caec2a03-39f0-4f46-aa02-21fbc85e210e", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a00dace-0d0b-4188-8080-930e3f547023");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe9d575d-dc19-4d11-9fbe-7cbad81c2dd6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5139881b-d1fb-4931-8194-6c8ab40c0708", "7abe6211-30aa-44ea-b57a-89d9d35239b6", "Admin", "ADMIN" });
        }
    }
}
