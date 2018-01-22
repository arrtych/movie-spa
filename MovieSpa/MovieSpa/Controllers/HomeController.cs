using MovieSpa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSpa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie()
            {
                Id = 1,
                Title = "New title1",
                Genre = "comedy",
                Year = 1985,
                Rating = 7.8,
                Description = "lorem impsum"


            });
            movies.Add(new Movie()
            {
                Id = 2,
                Title = "New title 2",
                Genre = "comedy",
                Year = 2007,
                Rating = 4.075,
                Description = "lorem impsum"


            });
            movies.Add(new Movie()
            {
                Id = 2,
                Title = "New title",
                Genre = "comedy",
                Year = 1965,
                Rating = 5,
                Description = "lorem impsum"


            });

            //returns from Views/Movie/List
            return View(movies);
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