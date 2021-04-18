using Microsoft.EntityFrameworkCore;
using StreetPetsData.Models;

namespace StreetPetsData.Data
{
    public class ApplicationDbContext : DbContext
    {
        //TODO: Relationships

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Person> Persons { get; set; }
    }
}
