using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Data.DTOs
{
    public class ReadAddressDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Name { get; set; }
        public object Adress { get; set; }

        public ReadAddressDTO()
        {
        }

        public ReadAddressDTO(int id, string name, object adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}
