using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bce3fef-3fea-4882-812d-6daa87ce1c0b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1df09c3-2c01-4422-ac50-de4b0068cc12", "fd7a6f06-5998-4ed7-a308-788b00df2209", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1df09c3-2c01-4422-ac50-de4b0068cc12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0bce3fef-3fea-4882-812d-6daa87ce1c0b", "571bb328-31ec-4a32-84d4-7d81aea6d264", "Admin", "ADMIN" });
        }
    }
}
