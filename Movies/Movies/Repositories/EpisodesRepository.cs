using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Models;
using Movies.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Movies.Repositories
{
    public class EpisodesRepository : IEpisodesRepository
    {
        public MoviesDb context;

        public EpisodesRepository(MoviesDb context)
        {
            this.context = context;
        }

        public List<Episode> GetAll() {

            return context.Episodes.ToList();
        }

        public Episode GetByImdbId(string ImdbId) {
            return context.Episodes.Where(x => x.ImdbId == ImdbId).FirstOrDefault();
        }

        public List<CheckEpisodes> GetSeen(IdentityUser User) {
            return context.CheckEpisodes.Where(x => x.User == User).ToList();   
        }

        public bool DeleteFromSeenByImdbId(string ImdbId,IdentityUser User) {
            var episode = context.CheckEpisodes.Where(x => x.User == User && x.Episode.ImdbId == ImdbId).FirstOrDefault();
             if (episode == null)
                 return false;
            context.CheckEpisodes.Remove(episode);
            context.SaveChanges();
            return true;
        }

        public bool AddEpisode(CheckEpisodes CheckEpisode)
        {
            try {
                context.Episodes.Add(CheckEpisode.Episode);
                context.CheckEpisodes.Add(CheckEpisode);
                context.SaveChanges();
                return true;
            }
            catch {
                return false;
            }

        }

    }
}