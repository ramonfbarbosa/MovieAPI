using AutoMapper;
using MovieAPI.Data.DTOs;
using MovieAPI.Models;

namespace MovieAPI.Profiles
{
    public class MovieTheaterProfile : Profile
    {
        public MovieTheaterProfile()
        {
            CreateMap<MovieTheaterDTO, MovieTheater>();
            CreateMap<MovieTheater, ReadMovieTheaterDTO>();
            CreateMap<UpdateMovieTheaterDTO, MovieTheater>();
        }
    }
}
