using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies;
        }

        [HttpGet("{id}")]
        public IActionResult FindMovieById(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(FindMovieById), new { Id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie([FromBody] Movie updatedMovie, int id)
        { 
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                movie.Title = updatedMovie.Title;
                movie.Director = updatedMovie.Director;
                movie.Duration = updatedMovie.Duration;
                movie.Genre = updatedMovie.Genre;
                _context.SaveChanges();

                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                _context.Remove(movie);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
    }
}
