using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicReviewer.Models
{
    public class ReviewerContext : DbContext
    {
        
        public DbSet<Album> Album { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Cover> Cover { get; set; }
    }
}