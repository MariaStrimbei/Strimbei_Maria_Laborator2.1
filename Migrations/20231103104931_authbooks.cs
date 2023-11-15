using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Strimbei_Maria_Laborator2._1.Migrations
{
    public partial class authbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "AuthorsID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorsID",
                table: "Book",
                column: "AuthorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorsID",
                table: "Book",
                column: "AuthorsID",
                principalTable: "Authors",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorsID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorsID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorsID",
                table: "Book");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorID",
                table: "Book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID");
        }
    }
}
