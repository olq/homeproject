using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicReviewer.Models;
using System.Data.Entity;
using System.IO;

namespace MusicReviewer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Reviews List";
            var db = new ReviewerContext();
            IEnumerable<Review> model = db.Review;
            return View(model);


        }
        public ActionResult AddNewAlbum()
        {
            ViewBag.Message = "Add a new Album to database";
            return View();
        }
        [HttpPost]
        public ActionResult AddNewAlbum(Album data, HttpPostedFileBase image)
        {
            using (var db = new ReviewerContext())

            {
                if (image != null)
                {
                    var binaryReader = new BinaryReader(image.InputStream);

                    var img = new Cover();
                    img.Image = binaryReader.ReadBytes(image.ContentLength);

                    img.Name = image.ContentType;
                    db.Cover.Add(img);
                }
                else
                {
                    var img = new Cover();
                    img.Image = null;
                    img.Name = null;
                    db.Cover.Add(img);
                }

                db.Album.Add(data);
                db.SaveChanges();
            }
            return View();
        }
        public ActionResult ShowAlbums()
        {
            using (var db = new ReviewerContext())
            {
                return View(db.Album.ToList());
            }

        }
        public FileContentResult GetImage(int coverId)
        {
            var db = new ReviewerContext();
            Cover cover = db.Cover.FirstOrDefault(p => p.Id == coverId);
            if (cover != null)
            {
                return new FileContentResult(cover.Image, cover.Name);
            }
            else 
            {
                return null; //we need to implement default image with "NO COVER YET" or sth like that.
            }
        }
        public ActionResult About()
        {
            return View();
        }


    }
}
