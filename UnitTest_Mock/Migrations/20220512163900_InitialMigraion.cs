using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitTest_Mock.Migrations
{
    public partial class InitialMigraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desgination = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Desgination", "Name" },
                values: new object[] { 1, "Fresher", "David Teo" });

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
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
