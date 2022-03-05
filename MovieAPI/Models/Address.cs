using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string PublicSpace { get; set; }
        public string District { get; set; }
        public int Number { get; set; }

        public Address()
        {
        }

        public Address(int id, string publicPlace, string district, int number)
        {
            Id = id;
            PublicSpace = publicPlace;
            District = district;
            Number = number;
        }
    }
}
