using Microsoft.AspNet.Identity.EntityFramework;
using Movies.Entities;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Repositories
{
    public class MoviesSeriesRepository : IMoviesSeriesRepository
    {

            public MoviesDb context;

            public MoviesSeriesRepository(MoviesDb context)
            {
                this.context = context;
            }

            public List<MovieSerie> GetAll()
            {
                return context.MoviesSeries.ToList();
            }

            public MovieSerie GetByImdbId(string ImdbId)
            {
                return context.MoviesSeries.Where(x => x.ImdbId == ImdbId).FirstOrDefault();
            }

            public List<CheckMoviesSeries> GetSeen(IdentityUser User)
            {
                return context.CheckMoviesSeries.Where(x => x.User == User).ToList();
            }

            public bool DeleteFromSeenByImdbId(string ImdbId, IdentityUser User)
            {          
                context.CheckMoviesSeries.Remove(context.CheckMoviesSeries.Where(x => x.MovieSerie.ImdbId == ImdbId).FirstOrDefault());
                context.SaveChanges();
                return true;
            }

            public bool AddMovieSerie(CheckMoviesSeries CheckMovieSerie)
            {
                try
                {
                    context.MoviesSeries.Add(CheckMovieSerie.MovieSerie);
                    context.CheckMoviesSeries.Add(CheckMovieSerie);
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }

        }
    }