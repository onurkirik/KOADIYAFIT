using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class data_seed_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "BMI", "DiabetType", "EMail", "Height", "MemberType", "Password", "UserName", "Weight", "WeightStatus" },
                values: new object[] { 1, 24, 24.0, "Tip-1", "admin@gmail.com", 176, "Admin", "pass", "admin", 83, "Fazla Kilolu" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "BMI", "DiabetType", "EMail", "Height", "MemberType", "Password", "UserName", "Weight", "WeightStatus" },
                values: new object[] { 2, 24, 24.0, "Tip-1", "user@gmail.com", 176, null, "pass", "user", 83, "Fazla Kilolu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
