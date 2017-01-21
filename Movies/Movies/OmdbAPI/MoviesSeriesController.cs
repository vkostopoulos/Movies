using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace Movies.OmdbAPI
{
    [Authorize]
    public class MoviesSeriesController : ApiController
    { 
        [Route("omdbapi/moviesseries/{Title}")] 
        public  IHttpActionResult Get(string Title)
        {

            ///   Series
            ///   
            ///  http://www.omdbapi.com/?t=battlestar&y=&plot=short&r=json
            /// 
            ///   {"Title":"Battlestar Galactica",
            ///   "Year":"2004–2009",
            ///   "Released":"14 Jan 2005",
            ///   "Genre":"Action, Adventure, Drama",
            ///   "Director":"N/A",
            ///   "Writer":"Glen A. Larson, Ronald D. Moore",
            ///   "Actors":"Edward James Olmos, Mary McDonnell, Jamie Bamber, James Callis","
            ///   Plot":"When an old enemy, the Cylons, resurface and obliterate the 12 colonies, the crew of the aged Galactica protect a small civilian fleet - the last of humanity - as they journey toward the fabled 13th colony, Earth.",
            ///   "Language":"English",
            ///   "Awards":"Won 3 Primetime Emmys. Another 34 wins & 89 nominations.",
            ///   "Poster":"https://images-na.ssl-images-amazon.com/images/M/MV5BMTc1NTg1MDk3NF5BMl5BanBnXkFtZTYwNDYyMjI3._V1_SX300.jpg",
            ///   "imdbRating":"8.7",
            ///   "imdbVotes":"123,660",
            ///   "imdbID":"tt0407362",
            ///   "Type":"series",
            ///   "totalSeasons":"4",
            ///   "Response":"True"}


            /// Movies
            /// 
            /// http://www.omdbapi.com/?t=transformers&y=&plot=short&r=json
            /// 
            ///{"Title":"Transformers",
            ///"Year":"2007",
            ///"Released":"03 Jul 2007",
            ///"Genre":"Action, Adventure, Sci-Fi",
            ///"Director":"Michael Bay",
            ///"Writer":"Roberto Orci (screenplay), Alex Kurtzman (screenplay), John Rogers (story), Roberto Orci (story), Alex Kurtzman (story)",
            ///"Actors":"Shia LaBeouf, Megan Fox, Josh Duhamel, Tyrese Gibson",
            ///"Plot":"An ancient struggle between two Cybertronian races, the heroic Autobots and the evil Decepticons, comes to Earth, with a clue to the ultimate power held by a teenager.",
            ///"Language":"English, Spanish",
            ///"Awards":"Nominated for 3 Oscars. Another 19 wins & 40 nominations.",
            ///"Poster":"https://images-na.ssl-images-amazon.com/images/M/MV5BNDg1NTU2OWEtM2UzYi00ZWRmLWEwMTktZWNjYWQ1NWM1OThjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
            ///"imdbRating":"7.1",
            ///"imdbVotes":"520,916",
            ///"imdbID":"tt0418279",
            ///"Type":"movie",
            ///"Response":"True"}

            string Url = "http://www.omdbapi.com/?y=&plot=short&r=json&t="+Title;

            CallService cl = new CallService();
            String s = cl.CallServiceGetResponse(Url);
            return Ok(s);

        }



    }
}