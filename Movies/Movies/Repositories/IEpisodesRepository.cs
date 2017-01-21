using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Movies.Repositories
{
    public interface IEpisodesRepository
    {
        List<Episode> GetAll();

        Episode GetByImdbId(string ImdbId);

        List<CheckEpisodes> GetSeen(IdentityUser User);

        bool DeleteFromSeenByImdbId(string ImdbId,IdentityUser User);

        bool AddEpisode(CheckEpisodes CheckEpisode);

    }
}