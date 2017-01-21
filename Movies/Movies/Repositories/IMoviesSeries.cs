using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Entities;

namespace Movies.Repositories
{
    public class IMoviesSeries
    {
        public List<MoviesSeries> GetAll { get; set; }

        public MoviesSeries GetByImdbId { get; set; }

        public List<MoviesSeries> GetSeen { get; set; }

        public bool DeleteFromSeenByImdbId { get; set; }

        public MoviesSeries FindMoviesSeries { get; set; }

        public bool CheckSeenMovieSerie { get; set; }

    }
}