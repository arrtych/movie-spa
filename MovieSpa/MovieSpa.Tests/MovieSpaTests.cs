using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieSpa.Models;
using MovieSpa.Repository;

namespace MovieSpa.Tests
{
    [TestClass]
    public class MovieSpaTests
    {
        [TestMethod]
        public void TestGetMovieByIdInRepository()
        {
            //arrange
            MovieRepository movieRepository = new MovieRepository();
            Movie searchedMovie = movieRepository.GetMovieByID(1);

            //actual
            int expectedID = 1;
           

            //assert
            Assert.AreEqual(expectedID, searchedMovie.Id);
        }
    }
}
