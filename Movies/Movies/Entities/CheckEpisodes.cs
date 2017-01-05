using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Movies.Entities
{
    public class CheckEpisodes
    {

        [Key]
        public int Id;

        [Required]
        public Episodes Episode;

        [Required]
        public DateTime Date;

        [Required]
        public IdentityUser User;


    }
}