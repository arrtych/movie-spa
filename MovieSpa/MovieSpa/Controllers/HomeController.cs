using MovieSpa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MovieSpa.Controllers
{
    public class HomeController : Controller
    {

        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

     

        public JsonResult GetData()
        {
            Movies movies = new Movies();
            List<Movie> data = movies.createList();
            var json = JsonConvert.SerializeObject(data);
            return new JsonResult {
                Data = json,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
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