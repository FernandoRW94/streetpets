using HotChocolate;
using HotChocolate.Data;
using StreetPetsData.Data;
using StreetPetsData.Models;
using System.Linq;

namespace StreetPetsAPI.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Breed> GetBreed([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.Breeds;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Pet> GetPet([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.Pets;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Person> GetPersons([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.Persons;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Address> GetAddresses([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.Addresses;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Comment> GetComments([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.Comments;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<PersonUpdateRecord> GetPersonUpdateRecord([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.PersonUpdateRecords;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<PetUpdateRecord> GetPetUpdateRecord([ScopedService] ApplicationDbContext dbContext)
        {
            return dbContext.PetUpdateRecords;
        }
    }
}
