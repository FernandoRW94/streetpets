using StreetPetsData.Models;
using System;

namespace StreetPetsData.Interfaces
{
    public interface IDateRegistry
    {
        public DateTime CreatedDate { get; set; }

        public int CreatedById { get; set; }

        public Person? CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int UpdatedById { get; set; }

        public Person? UpdatedBy { get; set; }

        public DateTime? DeactivatedDate { get; set; }

        public int DeactivatedById { get; set; }

        public Person? DeactivatedBy { get; set; }
    }
}
