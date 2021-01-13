using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Parcel> Parcels { get; set; }

        public DbSet<BagWithLetters> bagsWithLetters { get; set;}

        public DbSet<BagWithParcels> BagsWithParcels{ get; set; }

        public DbSet<Shipment> shipments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Parcel>()
                .HasData(
                    new Parcel {Number = "ee252525", 
                                RecepientName = "Vladyslav",
                                DestinationCountry = "Estonia",
                                Weight = 25.2,
                                Price = 12 }
                );

        }



    }
}
