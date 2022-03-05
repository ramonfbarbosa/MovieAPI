using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Data.DTOs.MovieTheaterDTO
{
    public class UpdateMovieTheaterDTO
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Name { get; set; }

        public UpdateMovieTheaterDTO()
        {
        }

        public UpdateMovieTheaterDTO(string name)
        {
            Name = name;
        }

    }
}
