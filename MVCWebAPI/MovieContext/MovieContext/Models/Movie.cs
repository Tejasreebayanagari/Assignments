using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieContext.Models
{

    public class Movie_Context : DbContext
    {
        public Movie_Context() : base("Name=MovieEntites")
        {

        }

        public DbSet<Movie_Context> Movies { get; set; }
    }
}