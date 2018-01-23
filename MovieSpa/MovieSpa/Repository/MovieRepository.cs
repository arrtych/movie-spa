using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieSpa.Models;

namespace MovieSpa.Repository
{
    public class MovieRepository : IMovieRepository
    {
       
        private Movies movies;

        public MovieRepository()
        {
            this.movies = new Movies();
        }

        public List<Movie> GetMovies()
        {
            return movies.createList();
        }



        public Movie GetMovieByID(int movieId)
        {
           //tested
            var value = GetMovies().Find(item => item.Id == movieId);
            return value;
        }

    }
}