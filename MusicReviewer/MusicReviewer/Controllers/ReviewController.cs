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
                return View(db.Reviews.ToList());
            }

        }
    }
}
