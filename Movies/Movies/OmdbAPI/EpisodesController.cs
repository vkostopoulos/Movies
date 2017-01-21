using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Movies.OmdbAPI
{
    [Authorize]
    public class EpisodesController : ApiController
    { 

    [Route("omdbapi/episode/{ImdbId}")]
    public IHttpActionResult Get(string ImdbId)
      {
        /// More Details
        /// 
        ///  http://www.omdbapi.com/?i=tt0519763&plot=short&r=json
        ///
        /// {"Title":"Bastille Day","Year":"2004","Rated":"TV-14","Released":"21 Jan 2005","Season":"1","Episode":"3","Runtime":"42 min","Genre":"Action, Adventure, Drama","Director":"Allan Kroeker","Writer":"Ronald D. Moore (developed by), Toni Graphia, David Weddle (story), Bradley Thompson (story), Glen A. Larson (based on the series created by: \"Battlestar Galactica\"), Carla Robinson (staff writer)","Actors":"Edward James Olmos, Mary McDonnell, Katee Sackhoff, Jamie Bamber","Plot":"Deciding to use the thousand prisoners on a prison transport ship to mine the ice on the planet they've found, Galactica's plans are upset when a political prisoner onboard leads an uprising, taking hostages. He questions the legitimacy of Roslin's government and demands free elections to be held in the fleet.","Language":"English","Country":"USA, UK, Canada","Awards":"N/A","Poster":"http://ia.media-imdb.com/images/M/MV5BMTUzNzY1Nzg0Nl5BMl5BanBnXkFtZTcwNTYxOTAzMQ@@._V1_SX300.jpg","Metascore":"N/A","imdbRating":"7.5","imdbVotes":"1247","imdbID":"tt0519763","seriesID":"tt0407362","Type":"episode","Response":"True"}

        string Url = "http://www.omdbapi.com/?plot=short&r=json&i=" + ImdbId;

        CallService cl = new CallService();
        String s = cl.CallServiceGetResponse(Url);
        return Ok(s);

        }
    }
}