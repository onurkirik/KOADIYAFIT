using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class Motivation_Words_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MotivationWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivationWords", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MotivationWords",
                columns: new[] { "Id", "Word" },
                values: new object[,]
                {
                    { 1, "Başarının yolu inanmaktan geçer." },
                    { 2, "Başarı: \"Baş\" olmak için \"arı\" gibi çalışmak gerekir." },
                    { 3, "Başarının yolu inanmaktan geçer." },
                    { 4, "Sana bunun kolay olacağını söylemiyorum. Buna değeceğini söylüyorum." },
                    { 5, "Eğer ağaca çıkmak istiyorsanız, yıldızlara çıkmaya niyet edin başarırsınız." },
                    { 6, "Motivasyon “başlamanı” sağlar. Devam etmen için “alışkanlık” olmalı." },
                    { 7, "Vazgeçmek üzereysen neden başladığını düşün." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MotivationWords");
        }
    }
}
