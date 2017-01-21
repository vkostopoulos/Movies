using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Movies.OmdbAPI
{
    [Authorize]
    public class SeasonsController : ApiController
    {
        [Route("omdbapi/moviesseries/{ImdbId}/Season/{SeasonNo}")]
        public IHttpActionResult Get(string ImdbId,int SeasonNo)
        {
            /// Episodes
            /// 
            ///  http://www.omdbapi.com/?t=battlestar&y=&plot=short&r=json&season=1
            /// 
            /// {"Title":"Battlestar Galactica",
            /// "Season":"1",
            /// "totalSeasons":"4",
            /// 
            /// "Episodes":[{"Title":"33",
            /// "Released":"2005-01-14",
            /// "Episode":"1",
            /// "imdbRating":"8.4",
            /// "imdbID":"tt0519761"}
            /// ,{"Title":"Water","Released":"2005-01-14","Episode":"2","imdbRating":"7.6","imdbID":"tt0519792"},{"Title":"Bastille Day","Released":"2005-01-21","Episode":"3","imdbRating":"7.5","imdbID":"tt0519763"},{"Title":"Act of Contrition","Released":"2005-01-28","Episode":"4","imdbRating":"7.7","imdbID":"tt0519762"},{"Title":"You Can't Go Home Again","Released":"2005-02-04","Episode":"5","imdbRating":"8.0","imdbID":"tt0519793"},{"Title":"Litmus","Released":"2005-02-11","Episode":"6","imdbRating":"7.5","imdbID":"tt0519778"},{"Title":"Six Degrees of Separation","Released":"2005-02-18","Episode":"7","imdbRating":"7.6","imdbID":"tt0519786"},{"Title":"Flesh and Bone","Released":"2005-02-25","Episode":"8","imdbRating":"7.8","imdbID":"tt0519769"},{"Title":"Tigh Me Up, Tigh Me Down","Released":"2005-03-04","Episode":"9","imdbRating":"7.4","imdbID":"tt0519790"},{"Title":"The Hand of God","Released":"2005-03-11","Episode":"10","imdbRating":"8.2","imdbID":"tt0519789"},{"Title":"Colonial Day","Released":"2005-03-18","Episode":"11","imdbRating":"7.5","imdbID":"tt0519765"},{"Title":"Kobol's Last Gleaming: Part 1","Released":"2005-03-25","Episode":"12","imdbRating":"8.0","imdbID":"tt0519774"},{"Title":"Kobol's Last Gleaming: Part 2","Released":"2005-04-01","Episode":"13","imdbRating":"8.4","imdbID":"tt0519775"}],"Response":"True"}

            string Url = "http://www.omdbapi.com/?y=&plot=short&r=json&i=" + ImdbId + "&season="+SeasonNo;

            CallService cl = new CallService();
            String s = cl.CallServiceGetResponse(Url);
            return Ok(s);

        }

    }
}