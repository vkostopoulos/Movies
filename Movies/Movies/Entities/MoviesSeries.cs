using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Entities
{
    public class MoviesSeries
    {

        [Key]  
        public int Id;

        [Required]
        public String Title;

        [Required]
        public String ImdbId;

        [Required]
        public String Type;

    }
}