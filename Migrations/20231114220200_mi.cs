using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Strimbei_Maria_Laborator2._1.Migrations
{
    public partial class mi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorID",
                table: "Book",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
