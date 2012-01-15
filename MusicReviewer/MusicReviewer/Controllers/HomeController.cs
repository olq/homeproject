using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicReviewer.Models;
using System.Data.Entity;

namespace MusicReviewer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Reviews List";
            using (var db = new ReviewerContext())
            {
                            return View(db.Reviews.ToList());
            }

        }
        public ActionResult AddNewAlbum()
        {
            ViewBag.Message = "Add a new Album to database";
            return View();
        }
        [HttpPost]
        public ActionResult AddNewAlbum(Album data)
        {
            using (var db = new ReviewerContext())
            {

                db.Albums.Add(data);
                db.SaveChanges();
            }
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}
