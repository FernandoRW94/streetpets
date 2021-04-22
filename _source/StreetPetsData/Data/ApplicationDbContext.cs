using Microsoft.EntityFrameworkCore;
using StreetPetsData.Models;

namespace StreetPetsData.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        //TODO: Relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Pets
            modelBuilder.Entity<Pet>()
                .HasOne(x => x.Breed)
                .WithMany(x => x.Pets);

            modelBuilder.Entity<Pet>()
                .HasOne(x => x.CreatedBy)
                .WithMany(x => x.Pets)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Pet>()
                .HasIndex(x => x.AddressId);
            modelBuilder.Entity<Pet>()
                .HasIndex(x => x.BreedId);
            modelBuilder.Entity<Pet>()
                .HasIndex(x => x.CreatedById);
            modelBuilder.Entity<Pet>()
                .HasIndex(x => x.EntityStatus);
            modelBuilder.Entity<Pet>()
                .HasIndex(x => x.Url);
            #endregion


            #region PersonFollowingPets
            modelBuilder.Entity<PersonFollowingPet>()
                .HasOne(x => x.Person)
                .WithMany(x => x.PersonFollowingPets)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PersonFollowingPet>()
                .HasOne(x => x.Pet)
                .WithMany(x => x.PersonFollowingPets)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion


            #region PetUpdateRecord
            modelBuilder.Entity<PetUpdateRecord>()
                .HasOne(x => x.Pet)
                .WithMany(x => x.PetUpdateRecords)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PetUpdateRecord>()
                .HasIndex(x => x.PetId);
            modelBuilder.Entity<PetUpdateRecord>()
                .HasIndex(x => x.ResponsableId);
            #endregion


            #region Comments
            modelBuilder.Entity<Comment>()
                .HasKey(x => new { x.Id, x.PetId });

            modelBuilder.Entity<Comment>()
                .HasOne(x => x.Pet)
                .WithMany(x => x.Comments)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
                .HasOne(x => x.CreatedBy)
                .WithMany(x => x.Comments)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
                .HasIndex(x => x.CreatedById);
            #endregion


            #region Persons
            modelBuilder.Entity<Person>()
                .HasIndex(x => x.AddressId);
            modelBuilder.Entity<Person>()
                .HasIndex(x => x.EntityStatus);
            #endregion


            #region PersonUpdateRecords
            modelBuilder.Entity<PersonUpdateRecord>()
                .HasOne(x => x.Person)
                .WithMany(x => x.PersonUpdateRecords)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonUpdateRecord>()
                .HasIndex(x => x.PersonId);
            modelBuilder.Entity<PersonUpdateRecord>()
                .HasIndex(x => x.ResponsableId);
            #endregion


            #region PersonFollowingPerson
            modelBuilder.Entity<PersonFollowingPerson>()
                .HasOne(x => x.Follower)
                .WithMany(x => x.FollowingPerson)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PersonFollowingPerson>()
                .HasOne(x => x.Followed)
                .WithMany(x => x.PersonsFollowing)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion


            #region Breeds
            modelBuilder.Entity<Breed>()
                .HasIndex(x => x.EntityStatus);
            #endregion


            #region Addresses
            modelBuilder.Entity<Address>()
                .HasIndex(x => x.EntityStatus);
            #endregion
        }


        #region Repositories

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<PetUpdateRecord> PetUpdateRecords { get; set; }

        public DbSet<PersonUpdateRecord> PersonUpdateRecords { get; set; }

        #endregion
    }
}
