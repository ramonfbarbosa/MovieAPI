using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Data.DTOs.MovieTheaterDTO
{
    public class MovieTheaterDTO
    {
        [Required(ErrorMessage = "You need to fill the field")]
        public string Name { get; set; }
        public int AdressFK { get; set; }
        public int ManagerFK { get; set; }

        public MovieTheaterDTO()
        {
        }
        public MovieTheaterDTO(string name, int adressFK, int managerFK)
        {
            Name = name;
            AdressFK = adressFK;
            ManagerFK = managerFK;
        }
    }
}
