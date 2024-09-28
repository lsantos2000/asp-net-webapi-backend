using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStore.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedExtraGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GenreId", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 6, 6, "The Legend of Zelda", 59.99m, new DateOnly(1986, 2, 21) },
                    { 7, 5, "Super Mario Bros.", 49.99m, new DateOnly(1985, 9, 13) },
                    { 8, 7, "Halo: Combat Evolved", 39.99m, new DateOnly(2001, 11, 15) },
                    { 9, 2, "The Witcher 3: Wild Hunt", 59.99m, new DateOnly(2015, 5, 19) },
                    { 10, 8, "Minecraft", 26.95m, new DateOnly(2011, 11, 18) },
                    { 11, 9, "Overwatch", 39.99m, new DateOnly(2016, 5, 24) },
                    { 12, 10, "Red Dead Redemption 2", 59.99m, new DateOnly(2018, 10, 26) },
                    { 13, 2, "Cyberpunk 2077", 59.99m, new DateOnly(2020, 12, 10) },
                    { 14, 11, "The Sims 4", 39.99m, new DateOnly(2014, 9, 2) },
                    { 15, 9, "Fortnite", 0.00m, new DateOnly(2017, 7, 25) },
                    { 16, 7, "Call of Duty: Modern Warfare", 59.99m, new DateOnly(2019, 10, 25) },
                    { 17, 2, "Assassin's Creed Valhalla", 59.99m, new DateOnly(2020, 11, 10) },
                    { 18, 11, "Animal Crossing: New Horizons", 59.99m, new DateOnly(2020, 3, 20) },
                    { 19, 7, "Doom Eternal", 59.99m, new DateOnly(2020, 3, 20) },
                    { 20, 12, "Among Us", 5.00m, new DateOnly(2018, 6, 15) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
