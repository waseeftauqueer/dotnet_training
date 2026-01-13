using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository_Pattern_Application_CC08.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("MoviesConnection")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}