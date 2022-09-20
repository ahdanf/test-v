using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestV.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vcName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vcEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vcAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intPhone = table.Column<int>(type: "int", nullable: false),
                    dtHire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dcSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
