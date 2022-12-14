using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOADIYAFIT.DAL.Migrations
{
    public partial class PersonalNote_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaNotId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonelNotes",
                columns: table => new
                {
                    PersonalNoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelNotes", x => x.PersonalNoteId);
                    table.ForeignKey(
                        name: "FK_PersonelNotes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelNotes_UserId",
                table: "PersonelNotes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelNotes");

            migrationBuilder.DropColumn(
                name: "PersonaNotId",
                table: "Users");
        }
    }
}
