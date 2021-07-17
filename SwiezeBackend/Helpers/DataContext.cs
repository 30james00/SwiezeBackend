using System;
using Bogus;
using Bogus.Extensions;
using Microsoft.EntityFrameworkCore;
using SwiezeBackend.Models;

namespace SwiezeBackend.Helpers
{
    public class DataContext : DbContext
    {
        private const int ClientCount = 100;
        private const int VendorCount = 100;
        private const int ContactCount = ClientCount + VendorCount;
        private const int ProductCount = 1000;
        private const int UnitTypeCount = 10;

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

            var fakeClient = new Faker<Client>()
                .RuleFor(o => o.ClientId, f => clientIndex)
                .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                .RuleFor(o => o.LastName, f => f.Person.LastName)
                .RuleFor(o => o.ContactId, f => clientIndex++);

            var fakeContact = new Faker<Contact>()
                .RuleFor(o => o.ContactId, f => contactIndex++)
                .RuleFor(o => o.Mail, f => f.Internet.Email())
                .RuleFor(o => o.Phone, f => f.Random.Int(111111111, 999999999).ToString())
                .RuleFor(o => o.Voivodeship, f => f.Address.State())
                .RuleFor(o => o.Voivodeship, f => f.Address.State())
                .RuleFor(o => o.PostalCode, f => $"{f.Random.String(2, 2, '0', '9')}-{f.Random.String(3, 3, '0', '9')}")
                .RuleFor(o => o.City, f => f.Address.City())
                .RuleFor(o => o.Street, f => f.Address.StreetName())
                .RuleFor(o => o.HouseNumber, f => f.Address.BuildingNumber())
                .RuleFor(o => o.FlatNumber, f => $"{f.Random.String(1, 3, '0', '9')}{f.Random.String(0, 1, 'A', 'Z')}");

            var fakeProduct = new Faker<Product>()
                .RuleFor(o => o.ProductId, f => productIndex++)
                .RuleFor(o => o.Name, f => f.Commerce.Product())
                .RuleFor(o => o.Value, f => f.Random.Int(1, 100000))
                .RuleFor(o => o.Unit, f => f.Random.Int(1, 100000))
                .RuleFor(o => o.Amount, f => f.Random.Int(1, 100000))
                .RuleFor(o => o.UnitTypeId, f => f.Random.Int(1, UnitTypeCount))
                .RuleFor(o => o.VendorId, f => f.Random.Int(1, VendorCount));

            var fakeUnitType = new Faker<UnitType>()
                .RuleFor(o => o.UnitTypeId, f => unitIndex++)
                .RuleFor(o => o.Name, f => f.Random.Word());

            var fakeVendor = new Faker<Vendor>()
                .RuleFor(o => o.VendorId, f => vendorIndex)
                .RuleFor(o => o.Name, f => f.Random.Word())
                .RuleFor(o => o.ContactId, f => ClientCount + vendorIndex++);

            modelBuilder.Entity<Contact>().HasData(
                fakeContact.GenerateBetween(ContactCount, ContactCount));

            modelBuilder.Entity<Client>().HasData(
                fakeClient.GenerateBetween(ClientCount, ClientCount));

            modelBuilder.Entity<Vendor>().HasData(
                fakeVendor.GenerateBetween(VendorCount, VendorCount));

            modelBuilder.Entity<UnitType>().HasData(
                fakeUnitType.GenerateBetween(UnitTypeCount, UnitTypeCount));

            modelBuilder.Entity<Product>().HasData(
                fakeProduct.GenerateBetween(ProductCount, ProductCount));
        }
    }
}