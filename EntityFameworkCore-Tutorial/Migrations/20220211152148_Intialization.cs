using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFameworkCore_Tutorial.Migrations
{
    public partial class Intialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)         //'Up' essentially means Forward moving
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Sales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }               

        protected override void Down(MigrationBuilder migrationBuilder)      //'Down' essentially means Reverse
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
