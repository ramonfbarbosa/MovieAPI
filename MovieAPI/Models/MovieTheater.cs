using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class MovieTheater
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "You need to fill the field")]
        public string Name { get; set; }

        public MovieTheater()
        {
        }
        public MovieTheater(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
