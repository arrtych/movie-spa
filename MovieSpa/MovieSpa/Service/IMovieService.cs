using MovieSpa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSpa.Service
{
    public interface IMovieService
    {
        Movie GetMovie(int id);

        List<Movie> ListOfMovies();
    }
}