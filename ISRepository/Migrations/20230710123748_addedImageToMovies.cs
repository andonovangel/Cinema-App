using Microsoft.EntityFrameworkCore.Migrations;

namespace ISHomework.Data.Migrations
{
    public partial class addedImageToMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieImage",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieImage",
                table: "Movies");
        }
    }
}
