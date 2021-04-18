using StreetPetsData.Interfaces;
using StreetPetsData.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class Person : IDateRegistry
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

        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public IEnumerable<Pet> Pets { get; set; }

        public IEnumerable<Pet> FollowingPets { get; set; }

        public IEnumerable<Person> FollowingPeople { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

        #region IDateRegistry

        public DateTime CreatedDate { get; set; }

        public int CreatedById { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public Person? CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int UpdatedById { get; set; }

        [ForeignKey(nameof(UpdatedById))]
        public Person? UpdatedBy { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        public int DeactivatedById { get; set; }

        [ForeignKey(nameof(DeactivatedById))]
        public Person? DeactivatedBy { get; set; }

        #endregion
    }
}
