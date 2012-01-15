using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicReviewer.Models
{
    public class ReviewerContext : DbContext
    {
        
        public DbSet<Album> Albums { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}