using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(new Villa
            {
                Id = 1,
                Name = "Royal Villa",
                Description = "Royal Villa provides beachfront accommodations in Trabzon. This villa offers free private parking and a shared kitchen.",
                ImageUrl = "https://limestays.com/wp-content/uploads/2023/01/34-926x618.jpg",
                Occupancy = 4,
                Price = 200,
                Sqft = 550
            },
            new Villa
            {
                Id = 2,
                Name = "Premium Pool Villa",
                Description = "Lexis Hibiscus Port Dickson, Port Dickson. No Reservation Costs. Great Rates. Villas. Apartments. 24/7 Customer Service. Hotels. Hostels. Great Availability. Flight + Hotel. Airport Taxi available. Low Rates. Special Offers. Amenities",
                ImageUrl = "https://image-tc.galaxy.tf/wijpeg-zql4sgfuf33lj1orh652feqe/lexis-hibiscus-port-dickson-premium-pool-villa-private-pool-1_wide.jpg?crop=0%2C188%2C2000%2C1125",
                Occupancy = 4,
                Price = 300,
                Sqft = 550
            },
            new Villa
            {
                Id = 3,
                Name = "Luxury Pool Villa",
                Description = "Soneva Kiri comprises 32 expansive one to five-bedroom luxury pool villas in Thailand that blend seamlessly with the island's natural beauty",
                ImageUrl = "https://www.ataman-resort.com/wp-content/uploads/2021/01/1-Villa-Luxury-front-view-night-1170x680.jpg",
                Occupancy = 4,
                Price = 400,
                Sqft = 750
            }

            );

            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                    Villa_Number = 101,
                    VillaId = 1,
                },
                 new VillaNumber
                 {
                     Villa_Number = 102,
                     VillaId = 1,
                 },
                  new VillaNumber
                  {
                      Villa_Number = 103,
                      VillaId = 1,
                  },
                   new VillaNumber
                   {
                       Villa_Number = 104,
                       VillaId = 1,
                   },
                    new VillaNumber
                    {
                        Villa_Number = 201,
                        VillaId = 2,
                    },
                     new VillaNumber
                     {
                         Villa_Number = 202,
                         VillaId = 2,
                     },
                      new VillaNumber
                      {
                          Villa_Number = 203,
                          VillaId = 2,
                      },
                       new VillaNumber
                       {
                           Villa_Number = 204,
                           VillaId = 2,
                       },
                        new VillaNumber
                        {
                            Villa_Number = 301,
                            VillaId = 3,
                        },
                         new VillaNumber
                         {
                             Villa_Number = 302,
                             VillaId = 3,
                         }
                      
                );
                
        }
    }
}
