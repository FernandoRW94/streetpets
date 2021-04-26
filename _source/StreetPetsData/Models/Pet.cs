using StreetPetsData.Interfaces;
using StreetPetsData.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Notes { get; set; }

        [Required]
        public int BreedId { get; set; }

        [ForeignKey(nameof(BreedId))]
        public Breed Breed { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }

        public bool IsBeingFed { get; set; }

        public PetStatus PetStatus { get; set; }

        public bool InRiskSituation { get; set; }

        public string RiskSituationDescription { get; set; }

        public string Picture { get; set; }

        public string MoreDetailsUrl { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public string Url { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public int CreatedById { get; set; }

        [ForeignKey("CreatedById")]
        public Person CreatedBy { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        public ICollection<PetUpdateRecord> PetUpdateRecords { get; set; }

        public ICollection<PersonFollowingPet> PersonFollowingPets { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
