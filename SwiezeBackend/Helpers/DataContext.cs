using System;
using Bogus;
using Bogus.Extensions;
using Microsoft.EntityFrameworkCore;
using SwiezeBackend.Models;

namespace SwiezeBackend.Helpers
{
    public class DataContext : DbContext
    {
        private const int UnitCount = 10;
        private const int ContactCount = 10;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Randomizer.Seed = new Random(58177474);

            var clientIndex = 1;
            var contactIndex = 1;
            var productIndex = 1;
            var unitIndex = 1;
            var vendorIndex = 1;


            
            var fakeUnitType = new Faker<UnitType>()
                .RuleFor(o => o.UnitTypeId, f => unitIndex++)
                .RuleFor(o => o.Name, f => f.Random.Word());

            modelBuilder.Entity<UnitType>().HasData(
                fakeUnitType.GenerateBetween(UnitCount,UnitCount));
        }
    }
}