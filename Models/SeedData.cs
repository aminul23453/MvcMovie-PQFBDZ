using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>());

        // Add sample movies only when the table is empty.
        if (context.Movie.Any())
        {
            return;
        }

        context.Movie.AddRange(
            new Movie
            {
                Title = "When Harry Met Sally",
                ReleaseDate = new DateTime(1989, 2, 12),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Rating = "R"
            },
            new Movie
            {
                Title = "Ghostbusters",
                ReleaseDate = new DateTime(1984, 3, 13),
                Genre = "Comedy",
                Price = 8.99M,
                Rating = "PG"
            },
            new Movie
            {
                Title = "Ghostbusters 2",
                ReleaseDate = new DateTime(1989, 2, 23),
                Genre = "Comedy",
                Price = 9.99M,
                Rating = "PG"
            },
            new Movie
            {
                Title = "Rio Bravo",
                ReleaseDate = new DateTime(1959, 4, 15),
                Genre = "Western",
                Price = 3.99M,
                Rating = "G"
            }
        );

        context.SaveChanges();
    }
}