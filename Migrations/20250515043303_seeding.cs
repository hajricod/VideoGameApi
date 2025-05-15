using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Nintendo EPD", "Nintendo Switch", "Nintendo", "The Legend of Zelda: Breath of the Wild" },
                    { 2, "CD Projekt Red", "PC, PS4, Xbox One, Nintendo Switch", "CD Projekt", "The Witcher 3: Wild Hunt" },
                    { 3, "Santa Monica Studio", "PS4, PC", "Sony Interactive Entertainment", "God of War" },
                    { 4, "FromSoftware", "PC, PS4, Xbox One, Nintendo Switch", "Bandai Namco Entertainment", "Dark Souls III" },
                    { 5, "Team Cherry", "PC, PS4, Xbox One, Nintendo Switch", "Team Cherry", "Hollow Knight" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
