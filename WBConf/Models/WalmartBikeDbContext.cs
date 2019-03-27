using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;


namespace WBConf.Models
{
    public class WalmartBikeDbContext : DbContext
    {
        public WalmartBikeDbContext(DbContextOptions<WalmartBikeDbContext> options) : base(options) { }
        public DbSet<Bike> Bike { get; set; }
        public DbSet<BikeConfiguration> BikeConf { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>()
                .HasMany(b => b.BikeConfs)
                .WithOne(e => e.CurrentBike);
             
         
        
            modelBuilder.Entity<BikeConfiguration>()
                .HasOne(e => e.CurrentBike)
                .WithMany(c => c.BikeConfs)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


        }
    }

}
