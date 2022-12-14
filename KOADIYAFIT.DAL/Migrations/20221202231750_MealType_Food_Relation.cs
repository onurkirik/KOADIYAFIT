using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class MealType_Food_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealType",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "MealTypeId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MealTypeId",
                table: "Foods",
                column: "MealTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_MealTypes_MealTypeId",
                table: "Foods",
                column: "MealTypeId",
                principalTable: "MealTypes",
                principalColumn: "MealTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_MealTypes_MealTypeId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_MealTypeId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "MealTypeId",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "MealType",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
