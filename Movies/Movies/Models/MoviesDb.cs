using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Movies.Entities;

namespace Movies.Models
{
    public class MoviesDb : DbContext
    {
            public MoviesDb() : base("name=DefaultConnection")
            {
                Database.SetInitializer<MoviesDb>(new DropCreateDatabaseIfModelChanges<MoviesDb>());
            }

            public DbSet<MovieSerie> MoviesSeries { get; set; }
            public DbSet<CheckEpisodes> CheckEpisodes { get; set; }
            public DbSet<CheckMoviesSeries> CheckMoviesSeries { get; set; }
            public DbSet<Episode> Episodes { get; set; }
            public DbSet<Share> Share { get; set; }

    }
}