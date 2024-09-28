using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStore.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fighting" },
                    { 2, "Roleplaying" },
                    { 3, "Sports" },
                    { 4, "Racing" },
                    { 5, "Kids and Family" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GenreId", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "Street Fighter", 59.99m, new DateOnly(1987, 8, 30) },
                    { 2, 2, "Final Fantasy", 49.99m, new DateOnly(1987, 12, 18) },
                    { 3, 3, "FIFA 21", 39.99m, new DateOnly(2020, 10, 9) },
                    { 4, 4, "Need for Speed", 29.99m, new DateOnly(1994, 8, 31) },
                    { 5, 5, "Mario Kart", 19.99m, new DateOnly(1992, 8, 27) },
                    { 6, 1, "The Legend of Zelda", 59.99m, new DateOnly(1986, 2, 21) },
                    { 7, 5, "Super Mario Bros.", 49.99m, new DateOnly(1985, 9, 13) },
                    { 8, 1, "Halo: Combat Evolved", 39.99m, new DateOnly(2001, 11, 15) },
                    { 9, 2, "The Witcher 3: Wild Hunt", 59.99m, new DateOnly(2015, 5, 19) },
                    { 10, 3, "Minecraft", 26.95m, new DateOnly(2011, 11, 18) },
                    { 11, 1, "Overwatch", 39.99m, new DateOnly(2016, 5, 24) },
                    { 12, 4, "Red Dead Redemption 2", 59.99m, new DateOnly(2018, 10, 26) },
                    { 13, 2, "Cyberpunk 2077", 59.99m, new DateOnly(2020, 12, 10) },
                    { 14, 5, "The Sims 4", 39.99m, new DateOnly(2014, 9, 2) },
                    { 15, 1, "Fortnite", 0.00m, new DateOnly(2017, 7, 25) },
                    { 16, 1, "Call of Duty: Modern Warfare", 59.99m, new DateOnly(2019, 10, 25) },
                    { 17, 2, "Assassin's Creed Valhalla", 59.99m, new DateOnly(2020, 11, 10) },
                    { 18, 5, "Animal Crossing: New Horizons", 59.99m, new DateOnly(2020, 3, 20) },
                    { 19, 1, "Doom Eternal", 59.99m, new DateOnly(2020, 3, 20) },
                    { 20, 5, "Among Us", 5.00m, new DateOnly(2018, 6, 15) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
