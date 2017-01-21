using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Entities;

namespace Movies.Repositories
{
    public class IShareRepository
    {
        public List<Share> GetAll { get; set; }

        public List<Share> GetForMe { get; set; }

    }
}