using MovieSpa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSpa.Repository
{
    public interface IMovieRepository
    {
        List <Movie> GetMovies();

        Movie GetMovieByID(int movieId);

        void Save();
    }
}