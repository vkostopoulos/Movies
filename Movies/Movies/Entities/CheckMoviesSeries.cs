using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Movies.Entities
{
    public class CheckMoviesSeries
    {
        [Key]
        public int Id;

        [Required]
        public MoviesSeries MovieSerie;

        [Required]
        public IdentityUser User;

        [Required]
        public DateTime Date;

    }
}