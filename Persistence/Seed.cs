using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions;
using Domain;
using Microsoft.AspNetCore.Identity;
using Persistence.Faker;

namespace Persistence
{
    public class Seed
    {
        private const int ClientCount = 100;
        private const int VendorCount = 100;
        private const int ContactCount = ClientCount + VendorCount;
        private const int AccountCount = 10;

        public static async Task SeedData(DataContext context, UserManager<Account> userManager)
        {
            Randomizer.Seed = new Random(58177474);

            var contactIndex = 1;

            if (!userManager.Users.Any())
            {
                var accountFaker = AccountFaker.Create();

                var users = new List<Account>();
                users.AddRange(accountFaker.GenerateBetween(AccountCount, AccountCount));

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            if (!context.Contacts.Any())
            {
                var contactFaker = ContactFaker.CreateWithId(contactIndex);

                var contacts = new List<Contact>();
                contacts.AddRange(contactFaker.GenerateBetween(ContactCount, ContactCount));

                await context.Contacts.AddRangeAsync(contacts);
                await context.SaveChangesAsync();
            }
        }
    }
}