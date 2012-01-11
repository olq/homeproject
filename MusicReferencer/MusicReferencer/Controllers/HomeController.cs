using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using MusicReferencer.Models;

namespace MusicReferencer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var Model = new MusicReferencerEntities2();

            return View(Model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
