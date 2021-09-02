using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions;
using Domain;

namespace Persistence
{
    public class Seed
    {
        private const int ClientCount = 100;
        private const int VendorCount = 100;
        private const int ContactCount = ClientCount + VendorCount;
        
        public static async Task SeedData(DataContext context)
        {
            Randomizer.Seed = new Random(58177474);
            
            var contactIndex = 1;
            
            if (!context.Contacts.Any())
            {
                var fakeContact = new Faker<Contact>()
                    .RuleFor(o => o.Id, f => ToGuid(contactIndex++))
                    .RuleFor(o => o.Mail, f => f.Internet.Email())
                    .RuleFor(o => o.Phone, f => f.Random.Int(111111111, 999999999).ToString())
                    .RuleFor(o => o.Voivodeship, f => f.Address.State())
                    .RuleFor(o => o.Voivodeship, f => f.Address.State())
                    .RuleFor(o => o.PostalCode, f => $"{f.Random.String(2, 2, '0', '9')}-{f.Random.String(3, 3, '0', '9')}")
                    .RuleFor(o => o.City, f => f.Address.City())
                    .RuleFor(o => o.Street, f => f.Address.StreetName())
                    .RuleFor(o => o.HouseNumber, f => f.Address.BuildingNumber())
                    .RuleFor(o => o.FlatNumber, f => $"{f.Random.String(1, 3, '0', '9')}{f.Random.String(0, 1, 'A', 'Z')}");
                
                var contacts = new List<Contact>();
                contacts.AddRange(fakeContact.GenerateBetween(ContactCount,ContactCount));
                
                await context.Contacts.AddRangeAsync(contacts);
                await context.SaveChangesAsync();
            }
        }
        
        private static Guid ToGuid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }
    }
}