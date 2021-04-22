using StreetPetsData.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class PetUpdateRecord
    {
        public int Id { get; set; }

        [Required]
        public int PetId { get; set; }

        [ForeignKey("PetId")]
        public Pet Pet { get; set; }

        public EntityUpdateEvent EntityUpdateEvent { get; set; }

        [Required]
        public int ResponsableId { get; set; }

        [Required]
        public string ResponsibleName { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
