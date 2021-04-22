using StreetPetsData.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class PersonUpdateRecord
    {
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        public EntityUpdateEvent EntityUpdateEvent { get; set; }

        [Required]
        public int ResponsableId { get; set; }

        [Required]
        public string ResponsibleName { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
