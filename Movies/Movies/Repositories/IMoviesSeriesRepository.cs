using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Movies.Repositories
{
    public interface IMoviesSeriesRepository
    {
        List<MovieSerie> GetAll();

        MovieSerie GetByImdbId(string ImdbId);

        List<CheckMoviesSeries> GetSeen(IdentityUser User);

        bool DeleteFromSeenByImdbId(string ImdbId, IdentityUser User);

        bool AddMovieSerie(CheckMoviesSeries CheckMovieSerie);

    }
}