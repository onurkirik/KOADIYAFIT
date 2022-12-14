using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class MeatlType_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealTypeImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.MealTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealTypes");
        }
    }
}
