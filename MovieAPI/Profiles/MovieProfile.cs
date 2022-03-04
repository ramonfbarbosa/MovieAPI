using AutoMapper;
using MovieAPI.Data.DTOs;
using MovieAPI.Models;

namespace MovieAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieDTO, Movie>();
            CreateMap<Movie, ReadMovieDTO>();
        }
    }
}
