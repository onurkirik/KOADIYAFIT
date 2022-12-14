using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortionSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorie = table.Column<int>(type: "int", nullable: false),
                    FoodImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    WeightStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DiabetType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodUser",
                columns: table => new
                {
                    FoodsForUsersFoodId = table.Column<int>(type: "int", nullable: false),
                    UsersForFoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodUser", x => new { x.FoodsForUsersFoodId, x.UsersForFoodsId });
                    table.ForeignKey(
                        name: "FK_FoodUser_Foods_FoodsForUsersFoodId",
                        column: x => x.FoodsForUsersFoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodUser_Users_UsersForFoodsId",
                        column: x => x.UsersForFoodsId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMeals",
                columns: table => new
                {
                    UserMealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCalorie = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMeals", x => x.UserMealId);
                    table.ForeignKey(
                        name: "FK_UserMeals_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodUserMeal",
                columns: table => new
                {
                    FoodsForUserMealsFoodId = table.Column<int>(type: "int", nullable: false),
                    UserMealsForFoodsUserMealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodUserMeal", x => new { x.FoodsForUserMealsFoodId, x.UserMealsForFoodsUserMealId });
                    table.ForeignKey(
                        name: "FK_FoodUserMeal_Foods_FoodsForUserMealsFoodId",
                        column: x => x.FoodsForUserMealsFoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodUserMeal_UserMeals_UserMealsForFoodsUserMealId",
                        column: x => x.UserMealsForFoodsUserMealId,
                        principalTable: "UserMeals",
                        principalColumn: "UserMealId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodUser_UsersForFoodsId",
                table: "FoodUser",
                column: "UsersForFoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodUserMeal_UserMealsForFoodsUserMealId",
                table: "FoodUserMeal",
                column: "UserMealsForFoodsUserMealId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMeals_UsersId",
                table: "UserMeals",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodUser");

            migrationBuilder.DropTable(
                name: "FoodUserMeal");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "UserMeals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
