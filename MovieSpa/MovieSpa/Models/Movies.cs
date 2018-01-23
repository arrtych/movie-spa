using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSpa.Models
{
    public class Movies
    {
        public Movies()
        {

        }

        public List<Movie> createList()
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie()
            {
                Id = 1,
                Title = "New title1",
                Genre = "comedy",
                Year = 1985,
                Rating = 7.8,
                Description = "lorem impsum"


            });
            movieList.Add(new Movie()
            {
                Id = 2,
                Title = "New title 2",
                Genre = "action",
                Year = 2007,
                Rating = 4.075,
                Description = "lorem impsum"


            });
            movieList.Add(new Movie()
            {
                Id = 3,
                Title = "New title3",
                Genre = "western",
                Year = 1965,
                Rating = 5,
                Description = "lorem impsum"


            });
            movieList.Add(new Movie()
            {
                Id = 4,
                Title = "New title4",
                Genre = "western",
                Year = 1977,
                Rating = 5,
                Description = "lorem impsum"


            });
            movieList.Add(new Movie()
            {
                Id = 5,
                Title = "New title5",
                Genre = "western",
                Year = 2007,
                Rating = 8,
                Description = "lorem impsum"


            });
            return movieList;
        }
    }
}