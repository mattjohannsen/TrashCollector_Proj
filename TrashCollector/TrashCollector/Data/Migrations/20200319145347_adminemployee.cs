using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class adminemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "275b88b7-84e4-43a4-b866-774472ef71ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "788617b7-8bf9-46c0-b666-98f5752d75fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bceb81c9-aecb-40d0-9a07-bb59d576d2e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ba6301b-c893-47f4-b431-c28ffd4fa0b5", "a664fd26-c654-439b-a678-7112c8be3aaa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac37cd2a-2449-49a3-aee4-fd14647abb3c", "536ba4ca-4d1d-49d6-aab1-29324ccd0358", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e2e58e6-0a4a-4f36-b5b7-32e9c5d193c1", "e819eca4-9eb6-466d-b4dd-234011506e4d", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e2e58e6-0a4a-4f36-b5b7-32e9c5d193c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ba6301b-c893-47f4-b431-c28ffd4fa0b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac37cd2a-2449-49a3-aee4-fd14647abb3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "788617b7-8bf9-46c0-b666-98f5752d75fe", "6c4a301f-4dfc-433d-acf7-828369ab184d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bceb81c9-aecb-40d0-9a07-bb59d576d2e2", "2781d844-996c-48aa-be88-285b1b93b6f8", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "275b88b7-84e4-43a4-b866-774472ef71ce", "a144d250-7d10-43a7-bffd-0c071c041ab3", "Customer", "CUSTOMER" });
        }
    }
}
