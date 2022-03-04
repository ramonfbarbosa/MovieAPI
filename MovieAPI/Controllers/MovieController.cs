using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using System.Collections.Generic;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController
    {
        private static List<Movie> movies = new List<Movie>();

        [HttpPost]
        public void AddMovie([FromBody] Movie movie)
        {
            movies.Add(movie);
            System.Console.WriteLine(movie.Title + " Added");
        }
    }
}
