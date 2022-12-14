using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class UserMeal_Fix_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodUserMeal");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "UserMeals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Portion",
                table: "UserMeals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserMeals_FoodId",
                table: "UserMeals",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMeals_Foods_FoodId",
                table: "UserMeals",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMeals_Foods_FoodId",
                table: "UserMeals");

            migrationBuilder.DropIndex(
                name: "IX_UserMeals_FoodId",
                table: "UserMeals");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "UserMeals");

            migrationBuilder.DropColumn(
                name: "Portion",
                table: "UserMeals");

            migrationBuilder.CreateTable(
                name: "FoodUserMeal",
                columns: table => new
                {
                    FoodsFoodId = table.Column<int>(type: "int", nullable: false),
                    UserMealsUserMealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodUserMeal", x => new { x.FoodsFoodId, x.UserMealsUserMealId });
                    table.ForeignKey(
                        name: "FK_FoodUserMeal_Foods_FoodsFoodId",
                        column: x => x.FoodsFoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodUserMeal_UserMeals_UserMealsUserMealId",
                        column: x => x.UserMealsUserMealId,
                        principalTable: "UserMeals",
                        principalColumn: "UserMealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodUserMeal_UserMealsUserMealId",
                table: "FoodUserMeal",
                column: "UserMealsUserMealId");
        }
    }
}
