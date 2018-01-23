using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieSpa.Models;
using MovieSpa.Repository;

namespace MovieSpa.Service
{
    public class MovieService : IMovieService
    {
        //A service layer is an additional layer in an ASP.NET MVC application that mediates communication
        //between a controller and repository layer.

        private MovieRepository _repository;

        public MovieService(MovieRepository repository)
        {
            this._repository = repository;
        }

        public Movie GetMovie(int id)
        {
            return _repository.GetMovieByID(id);
        }

        public List<Movie> ListOfMovies()
        {
            return _repository.GetMovies();
        }
    }
}