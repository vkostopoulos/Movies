using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Entities;

namespace Movies.Repositories
{
    public class IEpisodes
    {
        public List<Episodes> GetAll { get; set; }

        public Episodes GetByImdbId { get; set; }

        public List<Episodes> GetSeen { get; set; }

        public bool DeleteFromSeenByImdbId { get; set; }

        public Episodes FindEpisode { get; set; }

        public bool CheckSeenEpisode { get; set; }

    }
}