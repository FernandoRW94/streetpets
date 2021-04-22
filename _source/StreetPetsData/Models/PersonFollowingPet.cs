using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class PersonFollowingPet
    {
        [Key]
        public int Id { get; set; }

        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        public int PetId { get; set; }

        [ForeignKey("PetId")]
        public Pet Pet { get; set; }
    }
}
