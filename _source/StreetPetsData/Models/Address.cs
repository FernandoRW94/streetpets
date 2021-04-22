using StreetPetsData.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace StreetPetsData.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string Neighborhood { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public EntityStatus EntityStatus { get; set; }
    }
}
