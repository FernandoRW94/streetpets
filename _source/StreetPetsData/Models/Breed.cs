using StreetPetsData.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StreetPetsData.Models
{
    public class Breed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
