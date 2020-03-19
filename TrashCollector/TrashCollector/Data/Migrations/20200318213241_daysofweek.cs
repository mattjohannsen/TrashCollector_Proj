using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class daysofweek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b706ec7-a68a-4e42-85ad-e3a50fc43c2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3ae8140-d296-4dc0-ba46-1693c4b0c46b");

            migrationBuilder.AlterColumn<int>(
                name: "WeeklyPickUp",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DaysOfWeek",
                columns: table => new
                {
                    DaysOfWeekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOfWeek", x => x.DaysOfWeekId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b05706ab-484c-4524-b230-5bef5670d9dd", "572a4827-300a-45bd-9606-65ba974458f5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f317eb3e-6c20-4f20-a8f7-6bdede9e11ad", "301061ee-7378-4e4a-9abe-3a23b17fbccf", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "424ed1ff-fe8f-4427-99b2-3758aa663cfc", "d62c804d-3fab-4e42-afe2-8d6a7bf55c0f", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaysOfWeek");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "424ed1ff-fe8f-4427-99b2-3758aa663cfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05706ab-484c-4524-b230-5bef5670d9dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f317eb3e-6c20-4f20-a8f7-6bdede9e11ad");

            migrationBuilder.AlterColumn<string>(
                name: "WeeklyPickUp",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3ae8140-d296-4dc0-ba46-1693c4b0c46b", "e9589bc1-ee73-4e2a-9ca9-823857e5d808", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b706ec7-a68a-4e42-85ad-e3a50fc43c2d", "e1212846-d09b-4eb9-b5c5-ee24cd0d0f29", "Customer", "CUSTOMER" });
        }
    }
}
