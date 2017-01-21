using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Movies.Entities
{
    public class Share
    {

        [Key]
        public string ImdbId;

        [Required]
        public MovieSerie MovieSerie;

        [Required]
        public IdentityUser User;

        [Required]
        public string ToUsername;

        [Required]
        public string Comments;

        [Required]
        public DateTime Date;

    }
}