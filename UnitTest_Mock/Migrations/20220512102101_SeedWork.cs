using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitTest_Mock.Migrations
{
    public partial class SeedWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Desgination", "Name" },
                values: new object[] { 1, "Fresher", "Teo" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Desgination", "Name" },
                values: new object[] { 2, "Junior", "Ty" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Desgination", "Name" },
                values: new object[] { 3, "Senior", "Tun" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
