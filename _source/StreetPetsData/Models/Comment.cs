using StreetPetsData.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class Comment : IDateRegistry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

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
