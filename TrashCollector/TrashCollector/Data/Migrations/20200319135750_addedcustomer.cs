using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedcustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IdentityUserId",
                table: "Customer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer");

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

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
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
        }
    }
}
