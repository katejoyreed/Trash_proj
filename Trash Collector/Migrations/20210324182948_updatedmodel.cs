using Microsoft.EntityFrameworkCore.Migrations;

namespace Trash_Collector.Migrations
{
    public partial class updatedmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02ddc9e7-1842-411a-aaa9-4ee8152d49ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d773e6b-b515-46ee-b44c-4c28b1b268dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8124784d-0ff9-433d-b1f6-96404fadc58b");

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Zip",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81ac010a-669f-40e7-8107-e5d38606dd62", "e396657e-cf61-4502-a1e6-eb11aa213a52", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e13f565c-aeb1-4b35-9b4f-d08260b1492d", "79cfbeb0-b460-4603-a81f-92a2b06e64c4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd9d9767-ef42-4072-871e-69e72ee5adbe", "be6127f4-a5ba-414f-b9a8-f336ad659e52", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ac010a-669f-40e7-8107-e5d38606dd62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e13f565c-aeb1-4b35-9b4f-d08260b1492d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd9d9767-ef42-4072-871e-69e72ee5adbe");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02ddc9e7-1842-411a-aaa9-4ee8152d49ea", "bcba4e9b-ed9a-4af7-a02c-65bee5519bfa", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d773e6b-b515-46ee-b44c-4c28b1b268dd", "26842c59-1475-4f5b-840c-4001e4b07d3d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8124784d-0ff9-433d-b1f6-96404fadc58b", "c05123d1-3c85-4417-a806-a12c3ce57ee1", "Employee", "EMPLOYEE" });
        }
    }
}
