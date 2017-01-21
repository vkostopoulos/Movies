using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Entities
{
    public class Episode
    {
            
        [Key]
        public int Id;

        [Required]
        public string ImdbId;

        [Required]
        public string EpisodeTitle;

        [Required]
        public int SeasonNumber;

        [Required]
        public int EpisodeNumber;

        [Required]
        public MovieSerie Serie;

    }
}