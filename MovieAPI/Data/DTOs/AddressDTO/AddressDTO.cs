using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Data.DTOs
{
    public class AddressDTO
    {
        [Required(ErrorMessage = "You need to fill the field")]
        public string Name { get; set; }
        public int AdressFK { get; set; }
        public int ManagerFK { get; set; }

        public AddressDTO()
        {
        }
        public AddressDTO(string name, int adressFK, int managerFK)
        {
            Name = name;
            AdressFK = adressFK;
            ManagerFK = managerFK;
        }
    }
}
