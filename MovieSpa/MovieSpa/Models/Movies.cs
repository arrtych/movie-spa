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
                Title = "Inception",
                Genre = "Action, Adventure, Sci-Fi",
                Year = 2010,
                Rating = 8.8,
                Description = "A thief, who steals corporate secrets through the use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO."


            });
            movieList.Add(new Movie()
            {
                Id = 2,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Genre = "Adventure, Drama, Fantasy",
                Year = 2001,
                Rating = 8.8,
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."


            });
            movieList.Add(new Movie()
            {
                Id = 3,
                Title = "1+1",
                Genre = "Biography, Comedy, Drama",
                Year = 2011,
                Rating = 8.6,
                Description = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver."


            });
            movieList.Add(new Movie()
            {
                Id = 4,
                Title = "The Shawshank Redemption",
                Genre = "Crime, Drama",
                Year = 1994,
                Rating = 9.3,
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."


            });
            movieList.Add(new Movie()
            {
                Id = 5,
                Title = "Back to the Future",
                Genre = "Adventure, Comedy, Sci-Fi",
                Year = 1985,
                Rating = 8.5,
                Description = "Marty McFly, a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown."


            });
            return movieList;
        }
    }
}