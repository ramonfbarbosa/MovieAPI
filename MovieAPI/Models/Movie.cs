using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to fill the field")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need to fill the field")]
        public string Director { get; set; }
        [StringLength(30, ErrorMessage = "The field cannot exceed 30 characters")]
        public string Genre { get; set; }
        [Range(1, 600, ErrorMessage = "The duration must have a minimum of 1 and a maximum of 600 minutes")]
        public int Duration { get; set; }

        public Movie()
        {
        }
        public Movie(string title, string director, string genre, int duration)
        {
            Title = title;
            Director = director;
            Genre = genre;
            Duration = duration;
        }
    }
}
