﻿// <auto-generated />
using System;
using GameStore.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStore.Api.Data.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    partial class GameStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("GameStore.Api.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            Name = "Street Fighter",
                            Price = 59.99m,
                            ReleaseDate = new DateOnly(1987, 8, 30)
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 2,
                            Name = "Final Fantasy",
                            Price = 49.99m,
                            ReleaseDate = new DateOnly(1987, 12, 18)
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 3,
                            Name = "FIFA 21",
                            Price = 39.99m,
                            ReleaseDate = new DateOnly(2020, 10, 9)
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 4,
                            Name = "Need for Speed",
                            Price = 29.99m,
                            ReleaseDate = new DateOnly(1994, 8, 31)
                        },
                        new
                        {
                            Id = 5,
                            GenreId = 5,
                            Name = "Mario Kart",
                            Price = 19.99m,
                            ReleaseDate = new DateOnly(1992, 8, 27)
                        });
                });

            modelBuilder.Entity("GameStore.Api.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Roleplaying"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kids and Family"
                        });
                });

            modelBuilder.Entity("GameStore.Api.Entities.Game", b =>
                {
                    b.HasOne("GameStore.Api.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
