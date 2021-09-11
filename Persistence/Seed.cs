using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions;
using Domain;
using Persistence.Faker;

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
                var fakeContact = ContactFaker.Create(contactIndex);
                
                var contacts = new List<Contact>();
                contacts.AddRange(fakeContact.GenerateBetween(ContactCount,ContactCount));
                
                await context.Contacts.AddRangeAsync(contacts);
                await context.SaveChangesAsync();
            }
        }
        

    }
}