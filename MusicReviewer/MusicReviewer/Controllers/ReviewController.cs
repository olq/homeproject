using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicReviewer.Models;

namespace MusicReviewer.Controllers
{
    public class ReviewController : Controller
    {
        public ActionResult Index()
        {
            using(var db = new ReviewerContext())
            {
                return View(db.Review.ToList());
            }

        }
        public ActionResult AddNewReview(string AlbumId)

        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewReview(Review review)
        {
            if (review.ProfileId == 0)
            {
                review.ProfileId = 1;
            }
            var db = new ReviewerContext();
            db.Review.Add(review);
            db.SaveChanges();


            return View();
        }
    }
}
