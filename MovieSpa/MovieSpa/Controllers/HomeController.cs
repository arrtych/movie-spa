using MovieSpa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using MovieSpa.Service;
using MovieSpa.Repository;

namespace MovieSpa.Controllers
{
    public class HomeController : Controller
    {
        private MovieService _service;

        public HomeController()
        {
            this._service = new MovieService(new MovieRepository());
        }

        // Get Movies
        //Main method for return data by http request
        //return json data
        public JsonResult GetData()
        {
            List<Movie> data = this._service.ListOfMovies();
            var json = JsonConvert.SerializeObject(data);
            return new JsonResult
            {
                Data = json,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }


        //in url: /home/GetDataById/id
        public JsonResult GetDataById(int id)
        {
            return Json(this._service.GetMovie(id), JsonRequestBehavior.AllowGet);
        }



        public ActionResult Index()
        {
            return View();
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