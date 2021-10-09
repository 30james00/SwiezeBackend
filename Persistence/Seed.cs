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
        private const int CategoryCount = 10;
        private const int ClientCount = 10;
        private const int ProductCount = 100;
        private const int VendorCount = 10;
        //private const int ContactCount = ClientCount + VendorCount;
        private const int AccountCount = ClientCount + VendorCount;

        public static async Task SeedData(DataContext context, UserManager<Account> userManager)
        {
            Randomizer.Seed = new Random(58177474);

            var clientIndex = 1;
            var contactIndex = 1;
            var vendorIndex = 1;

            var categories = new List<Category>();
            var clients = new List<Client>();
            var contacts = new List<Contact>();
            var products = new List<Product>();
            var productCategories = new List<ProductCategory>();
            var users = new List<Account>();
            var unitTypes = new List<UnitType>();
            var vendors = new List<Vendor>();

            if (!userManager.Users.Any())
            {
                var accountFaker = AccountFaker.Create();


                users.AddRange(accountFaker.GenerateBetween(AccountCount, AccountCount));

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

            if (!context.Clients.Any())
            {
                var clientFaker = ClientFaker.CreateWithAccount(clientIndex, users);

                clients.AddRange(clientFaker.GenerateBetween(ClientCount, ClientCount));

                await context.Clients.AddRangeAsync(clients);
                await context.SaveChangesAsync();
            }

            if (!context.Vendors.Any())
            {
                var vendorFaker = VendorFaker.CreateWithAccount(vendorIndex, users);

                vendors.AddRange(vendorFaker.GenerateBetween(VendorCount, VendorCount));

                await context.Vendors.AddRangeAsync(vendors);
                await context.SaveChangesAsync();
            }

            if (!context.Contacts.Any())
            {
                var contactFaker = ContactFaker.CreateWithClient(contactIndex, 0, clients);
                contacts.AddRange(contactFaker.GenerateBetween(ClientCount, ClientCount));

                contactFaker = ContactFaker.CreateWithVendor(contactIndex + ClientCount, 0, vendors);
                contacts.AddRange(contactFaker.GenerateBetween(VendorCount, VendorCount));

                await context.Contacts.AddRangeAsync(contacts);
                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                if (!context.UnitTypes.Any())
                {
                    unitTypes.AddRange(new []
                    {
                        new UnitType{Name = "kg"},
                        new UnitType{Name = "l"},
                        new UnitType{Name = "unit"},
                    });

                    await context.UnitTypes.AddRangeAsync(unitTypes);
                    await context.SaveChangesAsync();
                }

                var productFaker = ProductFaker.Create(unitTypes, vendors);
                products.AddRange(productFaker.GenerateBetween(ProductCount, ProductCount));

                await context.Products.AddRangeAsync(products);
                await context.SaveChangesAsync();

                if (!context.Categories.Any())
                {
                    var categoryFaker = CategoryFaker.Create();
                    categories.AddRange(categoryFaker.GenerateBetween(CategoryCount, CategoryCount));

                    await context.Categories.AddRangeAsync(categories);
                    await context.SaveChangesAsync();
                }

                if (!context.ProductCategories.Any())
                {
                    var productCategoryFaker = ProductCategoryFaker.Create(products, categories);
                    productCategories.AddRange(productCategoryFaker.GenerateBetween(ProductCount, ProductCount));

                    await context.ProductCategories.AddRangeAsync(productCategories);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}