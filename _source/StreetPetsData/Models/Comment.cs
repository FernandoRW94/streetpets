using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int PetId { get; set; }

        [ForeignKey("PetId")]
        public Pet Pet { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public int CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public Person CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public DateTime? DeactivatedDate { get; set; }
    }
}
