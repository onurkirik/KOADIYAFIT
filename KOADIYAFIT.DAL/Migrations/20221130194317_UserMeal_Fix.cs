using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class UserMeal_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodUser_Foods_FoodsForUsersFoodId",
                table: "FoodUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodUser_Users_UsersForFoodsId",
                table: "FoodUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodUserMeal_Foods_FoodsForUserMealsFoodId",
                table: "FoodUserMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodUserMeal_UserMeals_UserMealsForFoodsUserMealId",
                table: "FoodUserMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMeals_Users_UsersId",
                table: "UserMeals");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "UserMeals",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMeals_UsersId",
                table: "UserMeals",
                newName: "IX_UserMeals_UserId");

            migrationBuilder.RenameColumn(
                name: "UserMealsForFoodsUserMealId",
                table: "FoodUserMeal",
                newName: "UserMealsUserMealId");

            migrationBuilder.RenameColumn(
                name: "FoodsForUserMealsFoodId",
                table: "FoodUserMeal",
                newName: "FoodsFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodUserMeal_UserMealsForFoodsUserMealId",
                table: "FoodUserMeal",
                newName: "IX_FoodUserMeal_UserMealsUserMealId");

            migrationBuilder.RenameColumn(
                name: "UsersForFoodsId",
                table: "FoodUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "FoodsForUsersFoodId",
                table: "FoodUser",
                newName: "FoodsFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodUser_UsersForFoodsId",
                table: "FoodUser",
                newName: "IX_FoodUser_UsersId");

            migrationBuilder.AddColumn<string>(
                name: "MealType",
                table: "UserMeals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUser_Foods_FoodsFoodId",
                table: "FoodUser",
                column: "FoodsFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUser_Users_UsersId",
                table: "FoodUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUserMeal_Foods_FoodsFoodId",
                table: "FoodUserMeal",
                column: "FoodsFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUserMeal_UserMeals_UserMealsUserMealId",
                table: "FoodUserMeal",
                column: "UserMealsUserMealId",
                principalTable: "UserMeals",
                principalColumn: "UserMealId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMeals_Users_UserId",
                table: "UserMeals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodUser_Foods_FoodsFoodId",
                table: "FoodUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodUser_Users_UsersId",
                table: "FoodUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodUserMeal_Foods_FoodsFoodId",
                table: "FoodUserMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodUserMeal_UserMeals_UserMealsUserMealId",
                table: "FoodUserMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_UserMeals_Users_UserId",
                table: "UserMeals");

            migrationBuilder.DropColumn(
                name: "MealType",
                table: "UserMeals");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserMeals",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMeals_UserId",
                table: "UserMeals",
                newName: "IX_UserMeals_UsersId");

            migrationBuilder.RenameColumn(
                name: "UserMealsUserMealId",
                table: "FoodUserMeal",
                newName: "UserMealsForFoodsUserMealId");

            migrationBuilder.RenameColumn(
                name: "FoodsFoodId",
                table: "FoodUserMeal",
                newName: "FoodsForUserMealsFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodUserMeal_UserMealsUserMealId",
                table: "FoodUserMeal",
                newName: "IX_FoodUserMeal_UserMealsForFoodsUserMealId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "FoodUser",
                newName: "UsersForFoodsId");

            migrationBuilder.RenameColumn(
                name: "FoodsFoodId",
                table: "FoodUser",
                newName: "FoodsForUsersFoodId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodUser_UsersId",
                table: "FoodUser",
                newName: "IX_FoodUser_UsersForFoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUser_Foods_FoodsForUsersFoodId",
                table: "FoodUser",
                column: "FoodsForUsersFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUser_Users_UsersForFoodsId",
                table: "FoodUser",
                column: "UsersForFoodsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUserMeal_Foods_FoodsForUserMealsFoodId",
                table: "FoodUserMeal",
                column: "FoodsForUserMealsFoodId",
                principalTable: "Foods",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodUserMeal_UserMeals_UserMealsForFoodsUserMealId",
                table: "FoodUserMeal",
                column: "UserMealsForFoodsUserMealId",
                principalTable: "UserMeals",
                principalColumn: "UserMealId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMeals_Users_UsersId",
                table: "UserMeals",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
