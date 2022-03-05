using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Data.DTOs
{
    public class UpdateAddressDTO
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Name { get; set; }

        public UpdateAddressDTO()
        {
        }

        public UpdateAddressDTO(string name)
        {
            Name = name;
        }

    }
}
