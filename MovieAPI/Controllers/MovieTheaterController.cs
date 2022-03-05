using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Data.DTOs;
using MovieAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieTheaterController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public MovieTheaterController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AddMovieTheater([FromBody] AddressDTO movieTheaterDTO)
        {
            MovieTheater movieTheater = _mapper.Map<MovieTheater>(movieTheaterDTO);
            _context.MoviesTheater.Add(movieTheater);
            _context.SaveChanges();
            return CreatedAtAction(nameof(FindMovieTheaterById), new { Id = movieTheater.Id }, movieTheater);
        }

        [HttpGet]
        public IEnumerable<MovieTheater> GetMovieTheater([FromQuery] string movieName)
        {
            return _context.MoviesTheater;
        }

        [HttpGet("{id}")]
        public IActionResult FindMovieTheaterById(int id)
        {
            MovieTheater movieTheater = _context.MoviesTheater.FirstOrDefault(movieTheater => movieTheater.Id == id);
            if (movieTheater != null)
            {
                ReadAddressDTO movieTheaterDTO = _mapper.Map<ReadAddressDTO>(movieTheater);

                return Ok(movieTheaterDTO);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovieTheater(int id, [FromBody] AddressDTO movieTheaterDTO)
        {
            MovieTheater movieTheater = _context.MoviesTheater.FirstOrDefault(movieTheater => movieTheater.Id == id);
            if (movieTheater == null)
            {
                return NotFound();
            }
            _mapper.Map(movieTheaterDTO, movieTheater);
            _context.SaveChanges();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteMovieTheater(int id)
        {
            MovieTheater movieTheater = _context.MoviesTheater.FirstOrDefault(movieTheater => movieTheater.Id == id);
            if (movieTheater == null)
            {
                return NotFound();
            }
            _context.Remove(movieTheater);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
