using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieSpa;
using MovieSpa.Controllers;
using MovieSpa.Models;
using MovieSpa.Repository;
using MovieSpa.Service;

namespace MovieSpa.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void TestGetMovieByIdInRepository()
        {
            //arrange
            MovieRepository movieRepository = new MovieRepository();


            //actual
            Movie searchedMovie = movieRepository.GetMovieByID(1);
            int expectedID = 1;


            //assert
            Assert.AreEqual(expectedID, searchedMovie.Id);
        }

        [TestMethod]
        public void TestGetMovieByIdInService()
        {
            //arrange
            MovieService service = new MovieService(new MovieRepository());


            //actual
            Movie searchedMovie = service.GetMovie(1);
            int expectedID = 1;

            //assert
            Assert.AreEqual(expectedID, searchedMovie.Id);
        }

        [TestMethod]
        public void TestListOfMoviesInService()
        {
            //arrange
            MovieService service = new MovieService(new MovieRepository());
            List<Movie> list = service.ListOfMovies();

            //actual
            int expectedListCount = 5;

            //assert
            Assert.AreEqual(expectedListCount, list.Count);
        }

        [TestMethod]
        public void TestMovieDetailsByIdInService()
        {
            //arrange
            MovieService service = new MovieService(new MovieRepository());
            Movie searchedMovie = service.GetMovie(1);

            //actual
            string expectedMovieDescription = "A thief, who steals corporate secrets through the use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.";

            //assert
            Assert.AreEqual(expectedMovieDescription, searchedMovie.Description);
        }

    }
}
