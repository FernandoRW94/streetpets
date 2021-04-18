using System.ComponentModel.DataAnnotations;

namespace StreetPetsData.Models
{
    public class Breed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
