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
            new { Id = 5, Title = "Mario Kart", GenreId = 5, Name = "Mario Kart", Price = 19.99m, ReleaseDate = new DateOnly(1992, 8, 27) }
        );
    }
}
