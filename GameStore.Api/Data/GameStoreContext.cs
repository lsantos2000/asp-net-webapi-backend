using GameStore.Api.Entities;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
    : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Fighting" },
            new { Id = 2, Name = "Roleplaying" },
            new { Id = 3, Name = "Sports" },
            new { Id = 4, Name = "Racing" },
            new { Id = 5, Name = "Kids and Family" }
        );

        modelBuilder.Entity<Game>().HasData(
            new { Id = 1, Title = "Street Fighter", GenreId = 1, Name = "Street Fighter", Price = 59.99m, ReleaseDate = new DateOnly(1987, 8, 30) },
            new { Id = 2, Title = "Final Fantasy", GenreId = 2, Name = "Final Fantasy", Price = 49.99m, ReleaseDate = new DateOnly(1987, 12, 18) },
            new { Id = 3, Title = "FIFA 21", GenreId = 3, Name = "FIFA 21", Price = 39.99m, ReleaseDate = new DateOnly(2020, 10, 9) },
            new { Id = 4, Title = "Need for Speed", GenreId = 4, Name = "Need for Speed", Price = 29.99m, ReleaseDate = new DateOnly(1994, 8, 31) },
            new { Id = 5, Title = "Mario Kart", GenreId = 5, Name = "Mario Kart", Price = 19.99m, ReleaseDate = new DateOnly(1992, 8, 27) },
            new { Id = 6, Title = "The Legend of Zelda", GenreId = 1, Name = "The Legend of Zelda", Price = 59.99m, ReleaseDate = new DateOnly(1986, 2, 21) },
            new { Id = 7, Title = "Super Mario Bros.", GenreId = 5, Name = "Super Mario Bros.", Price = 49.99m, ReleaseDate = new DateOnly(1985, 9, 13) },
            new { Id = 8, Title = "Halo: Combat Evolved", GenreId = 1, Name = "Halo: Combat Evolved", Price = 39.99m, ReleaseDate = new DateOnly(2001, 11, 15) },
            new { Id = 9, Title = "The Witcher 3: Wild Hunt", GenreId = 2, Name = "The Witcher 3: Wild Hunt", Price = 59.99m, ReleaseDate = new DateOnly(2015, 5, 19) },
            new { Id = 10, Title = "Minecraft", GenreId = 3, Name = "Minecraft", Price = 26.95m, ReleaseDate = new DateOnly(2011, 11, 18) },
            new { Id = 11, Title = "Overwatch", GenreId = 1, Name = "Overwatch", Price = 39.99m, ReleaseDate = new DateOnly(2016, 5, 24) },
            new { Id = 12, Title = "Red Dead Redemption 2", GenreId = 4, Name = "Red Dead Redemption 2", Price = 59.99m, ReleaseDate = new DateOnly(2018, 10, 26) },
            new { Id = 13, Title = "Cyberpunk 2077", GenreId = 2, Name = "Cyberpunk 2077", Price = 59.99m, ReleaseDate = new DateOnly(2020, 12, 10) },
            new { Id = 14, Title = "The Sims 4", GenreId = 5, Name = "The Sims 4", Price = 39.99m, ReleaseDate = new DateOnly(2014, 9, 2) },
            new { Id = 15, Title = "Fortnite", GenreId = 1, Name = "Fortnite", Price = 0.00m, ReleaseDate = new DateOnly(2017, 7, 25) },
            new { Id = 16, Title = "Call of Duty: Modern Warfare", GenreId = 1, Name = "Call of Duty: Modern Warfare", Price = 59.99m, ReleaseDate = new DateOnly(2019, 10, 25) },
            new { Id = 17, Title = "Assassin's Creed Valhalla", GenreId = 2, Name = "Assassin's Creed Valhalla", Price = 59.99m, ReleaseDate = new DateOnly(2020, 11, 10) },
            new { Id = 18, Title = "Animal Crossing: New Horizons", GenreId = 5, Name = "Animal Crossing: New Horizons", Price = 59.99m, ReleaseDate = new DateOnly(2020, 3, 20) },
            new { Id = 19, Title = "Doom Eternal", GenreId = 1, Name = "Doom Eternal", Price = 59.99m, ReleaseDate = new DateOnly(2020, 3, 20) },
            new { Id = 20, Title = "Among Us", GenreId = 5, Name = "Among Us", Price = 5.00m, ReleaseDate = new DateOnly(2018, 6, 15) }
        );
    }
}
