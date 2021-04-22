using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StreetPetsData.Data;
using StreetPetsData.Models;
using StreetPetsData.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPetsData.Seed
{
    public static class Seeder
    {
        public static void ApplyMigrations(IServiceScopeFactory scopeFactory)
        {
            using (IServiceScope serviceScope = scopeFactory.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
            }
        }

        public static async Task SeedBreeds(IServiceScopeFactory scopeFactory)
        {
            using(IServiceScope serviceScope = scopeFactory.CreateScope())
            {
                try
                {
                    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    if(dbContext.Breeds.Any())
                    {
                        return;
                    }

                    var breeds = new List<Breed>()
                    {
                        new Breed { Name = "Mutt", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Caramel Dog", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Border Collie", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Shitzu", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Poodle", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Chihuahua", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Beagle", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "German Sheperd", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "Collie", EntityStatus = EntityStatus.ACTIVE },
                        new Breed { Name = "German Sheperd", EntityStatus = EntityStatus.ACTIVE }
                    };

                    await dbContext.Breeds.AddRangeAsync(breeds);
                    await dbContext.SaveChangesAsync();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }
    }
}
