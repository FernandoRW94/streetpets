using StreetPetsData.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Description { get; set; }

        [Required]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }

        public EntityStatus EntityStatus { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        /// <summary>
        /// List of Pets this Person has created.
        /// </summary>
        public ICollection<Pet> Pets { get; set; }

        /// <summary>
        /// List of Pets this Person follows.
        /// </summary>
        public ICollection<PersonFollowingPet> PersonFollowingPets { get; set; }

        /// <summary>
        /// List of the people this Person follows.
        /// </summary>
        public ICollection<PersonFollowingPerson> FollowingPerson { get; set; }

        /// <summary>
        /// List of the people that follows this Person.
        /// </summary>
        public ICollection<PersonFollowingPerson> PersonsFollowing { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<PersonUpdateRecord> PersonUpdateRecords { get; set; }
    }
}
