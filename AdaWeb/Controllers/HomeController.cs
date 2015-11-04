using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdaWeb.Models;

namespace AdaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Another Title";
            return View();
        }

        public ActionResult MovieDetail()
        {
            var model = new Movie
            {
                Name = "The Martian",
                Rating = 4,
                ReleaseDate = new DateTime(2015, 10, 1)
            };
            return View(model);
        }


        public ActionResult MovieList()
        {
            var model = new List<Movie>();
            model.Add(new Movie
            {
                Name = "The Martian",
                Rating = 4,
                ReleaseDate = new DateTime(2015, 10, 1)
            });
            model.Add(new Movie
            {
                Name = "MadMax",
                Rating = 3,
                ReleaseDate = new DateTime(2015, 9, 1)
            });

            model.Add(new Movie
            {
                Name = "Gravity",
                Rating = 4,
                ReleaseDate = new DateTime(2013, 10, 1)
            });

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}