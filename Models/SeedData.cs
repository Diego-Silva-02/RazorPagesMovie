using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look foy any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                // else
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Iron Man 7",
                        ReleaseDate = DateTime.Parse("2030-10-10"),
                        Genre = "Hero Action",
                        Price = 200.70M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Pokemon Unite - The Film",
                        ReleaseDate = DateTime.Now,
                        Genre = "Animation Action",
                        Price = 149.99M,
                        Rating = "S"
                    },
                    new Movie
                    {
                        Title = "Dragon Ball AF - The Sage of Sayadin 5",
                        ReleaseDate = DateTime.Parse("2025-5-10"),
                        Genre = "Animation Action Comedy",
                        Price = 180.37M,
                        Rating = "A"
                    },
                    new Movie
                    {
                        Title = "Toy Story 5",
                        ReleaseDate = DateTime.Parse("2026-4-19"),
                        Genre = "Animation Comedy",
                        Price = 50.70M,
                        Rating = "B"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
