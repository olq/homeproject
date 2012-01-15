using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MusicReviewer.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string Band { get; set; }
        public ICollection<Song> Songs { get; set; }
 
    }
    
    public class Profile 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Review> Reviews {get; set;}

    }
    public class Review
    {
        public int Id { get; set; }
 
        public string Name { get; set; }
        public decimal AlbumRate { get; set; }
        public decimal ReviewRate { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        
    }
    public class Song
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
    }


}