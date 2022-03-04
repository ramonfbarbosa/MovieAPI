using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        private static int id = 1;

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult FindMovieById(int id)
        {
            Movie movie = movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        { 
            movie.Id = id++;
            movies.Add(movie);
            return CreatedAtAction(nameof(FindMovieById), new { Id = movie.Id }, movie);

        }

        
    }
}
