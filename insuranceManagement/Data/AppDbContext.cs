using insuranceManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=10.3.117.39;Database=insurance-1000075330;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vehicle>()
                .HasOne<Policy>(a => a.policy)
                .WithOne(b => b.vehicle)
                .HasForeignKey<Policy>(b => b.vehicleId);

            builder.Entity<Policy>()
                .HasOne<Vehicle>(a => a.vehicle)
                .WithOne(b => b.policy)
                .HasForeignKey<Policy>(b => b.vehicleId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<Claims> Claims { get; set; }
    }
}
