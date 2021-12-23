using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Domain;
using Microsoft.AspNetCore.Identity;
using Persistence.Faker;

namespace Persistence
{
    public class SeedAlt
    {
        public static async Task SeedData(DataContext context, UserManager<Account> userManager, bool isCompact)
        {
            var random = new Random(58177474);
            Randomizer.Seed = new Random(58177474);

            var carts = new List<Cart>();
            var categories = new List<Category>();
            var clients = new List<Client>();
            var contacts = new List<Contact>();
            var coupons = new List<Coupon>();
            var orders = new List<Order>();
            var orderItems = new List<OrderItem>();
            var products = new List<Product>();
            var productCategories = new List<ProductCategory>();
            var reviews = new List<Review>();
            var users = new List<Account>();
            var unitTypes = new List<UnitType>();

            var vendors = new List<Vendor>();
            if (!userManager.Users.Any())
            {
                var accountFaker = AccountFaker.Create();


                users = new List<Account>
                {
                    new Account
                    {
                        UserName = "jan.kowalski",
                        Email = "jan.kowalski@gmail.com",
                    },
                    new Account
                    {
                        UserName = "nowak",
                        Email = "contact@nowak.pl",
                    },
                    new Account
                    {
                        UserName = "tomasz",
                        Email = "contact@tomasz.pl",
                    }
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }


                if (!context.Clients.Any())
                {
                    clients = new List<Client>
                    {
                        new Client
                        {
                            AccountId = users[0].Id,
                            FirstName = "Jan",
                            LastName = "Nowak",
                        },
                    };
                    await context.Clients.AddRangeAsync(clients);
                    await context.SaveChangesAsync();
                }

                if (!context.Vendors.Any())
                {
                    vendors = new List<Vendor>
                    {
                        new Vendor { AccountId = users[1].Id, Name = "Gospodarstwo Rolne Adam Nowak", },
                        new Vendor { AccountId = users[2].Id, Name = "OwoceWarzywa", },
                    };

                    await context.Vendors.AddRangeAsync(vendors);
                    await context.SaveChangesAsync();
                }

                if (!context.Contacts.Any())
                {
                    contacts = new List<Contact>
                    {
                        new Contact
                        {
                            AccountId = users[0].Id,
                            City = "Lublin",
                            Mail = "jan.kowalski@gmail.com",
                            Phone = "600100200",
                            Street = "Turkusowa",
                            Voivodeship = "Lubelskie",
                            HouseNumber = "24A",
                            PostalCode = "20-400",
                        },
                        new Contact
                        {
                            AccountId = users[1].Id,
                            City = "Stasin",
                            Mail = "contact@nowak.pl",
                            Phone = "600444111",
                            Street = "Angielska",
                            Voivodeship = "Lubelskie",
                            HouseNumber = "24",
                            FlatNumber = "1",
                            PostalCode = "21-500",
                        },
                        new Contact
                        {
                            AccountId = users[2].Id,
                            City = "Markuszów",
                            Mail = "contact@tomasz.pl",
                            Phone = "+48600100200",
                            Street = "Turkusowa",
                            Voivodeship = "Lubelskie",
                            HouseNumber = "24",
                            PostalCode = "20-500",
                        },
                    };

                    await context.Contacts.AddRangeAsync(contacts);
                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    if (!context.UnitTypes.Any())
                    {
                        unitTypes.AddRange(new[]
                        {
                            new UnitType { Id = GuidHelper.ToGuid(1), Name = "g" },
                            new UnitType { Id = GuidHelper.ToGuid(2), Name = "ml" },
                            new UnitType { Id = GuidHelper.ToGuid(3), Name = "szt" },
                        });

                        await context.UnitTypes.AddRangeAsync(unitTypes);
                        await context.SaveChangesAsync();
                    }

                    products = new List<Product>
                    {
                        new Product
                        {
                            UnitTypeId = unitTypes[0].Id,
                            VendorId = vendors[0].Id,
                            Name = "Marchew",
                            Unit = 100000,
                            Stock = 100,
                            Value = 120,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[0].Id,
                            VendorId = vendors[0].Id,
                            Name = "Jabłka",
                            Unit = 10000,
                            Stock = 500,
                            Value = 200,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[2].Id,
                            VendorId = vendors[0].Id,
                            Name = "Kapusta",
                            Unit = 100,
                            Stock = 100,
                            Value = 150,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[1].Id,
                            VendorId = vendors[0].Id,
                            Name = "Jagody",
                            Unit = 25000,
                            Stock = 200,
                            Value = 300,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[0].Id,
                            VendorId = vendors[0].Id,
                            Name = "Brzoskwinie",
                            Unit = 10000,
                            Stock = 100,
                            Value = 1000,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[2].Id,
                            VendorId = vendors[1].Id,
                            Name = "Sałata",
                            Unit = 100,
                            Stock = 34,
                            Value = 560,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[0].Id,
                            VendorId = vendors[1].Id,
                            Name = "Pomidory",
                            Unit = 40000,
                            Stock = 100,
                            Value = 899,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[2].Id,
                            VendorId = vendors[1].Id,
                            Name = "Gruszki",
                            Unit = 300,
                            Stock = 40,
                            Value = 1200,
                        },
                        new Product
                        {
                            UnitTypeId = unitTypes[0].Id,
                            VendorId = vendors[1].Id,
                            Name = "Rzodkiew",
                            Unit = 20000,
                            Stock = 100,
                            Value = 500,
                        },
                    };

                    await context.Products.AddRangeAsync(products);
                    await context.SaveChangesAsync();

                    if (!context.Categories.Any())
                    {
                        categories = new List<Category>
                        {
                            new Category
                            {
                                Name = "Warzywa",
                                Description = "Swieże warzywa",
                            },
                            new Category
                            {
                                Name = "Owoce",
                                Description = "Świeże owoce",
                            },
                        };

                        await context.Categories.AddRangeAsync(categories);
                        await context.SaveChangesAsync();
                    }

                    if (!context.ProductCategories.Any())
                    {
                        productCategories = new List<ProductCategory>
                        {
                            new ProductCategory
                            {
                                ProductId = products[0].Id,
                                CategoryId = categories[0].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[1].Id,
                                CategoryId = categories[1].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[2].Id,
                                CategoryId = categories[0].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[3].Id,
                                CategoryId = categories[1].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[4].Id,
                                CategoryId = categories[1].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[5].Id,
                                CategoryId = categories[0].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[6].Id,
                                CategoryId = categories[0].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[7].Id,
                                CategoryId = categories[1].Id,
                            },
                            new ProductCategory
                            {
                                ProductId = products[8].Id,
                                CategoryId = categories[0].Id,
                            },
                        };

                        await context.ProductCategories.AddRangeAsync(productCategories);
                        await context.SaveChangesAsync();
                    }

                    // if (!context.Carts.Any())
                    // {
                    //     var cartFaker = CartFaker.Create(clients, products);
                    //     carts.AddRange(cartFaker.GenerateBetween(cartCount, cartCount));
                    //
                    //     await context.Carts.AddRangeAsync(carts);
                    //     await context.SaveChangesAsync();
                    // }

                    if (!context.Orders.Any())
                    {
                        orders = new List<Order>
                        {
                            new Order
                            {
                                ClientId = clients[0].Id,
                                VendorId = vendors[0].Id,
                                OrderDate = DateTime.Now.Subtract(TimeSpan.FromDays(39)),
                                IsCanceled = true,
                            },
                            new Order
                            {
                                ClientId = clients[0].Id,
                                VendorId = vendors[0].Id,
                                OrderDate = DateTime.Now.Subtract(TimeSpan.FromDays(30)),
                                FulfillmentDate = DateTime.Now.Subtract(TimeSpan.FromDays(28)),
                            },
                        };

                        await context.Orders.AddRangeAsync(orders);
                        await context.SaveChangesAsync();

                        if (!context.OrderItems.Any())
                        {
                            orderItems = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    ProductId = products[0].Id,
                                    OrderId = orders[1].Id,
                                    Amount = 2,
                                    Value = products[0].Value,
                                },
                                new OrderItem
                                {
                                    ProductId = products[3].Id,
                                    OrderId = orders[1].Id,
                                    Amount = 2,
                                    Value = products[3].Value,
                                },
                            };

                            await context.OrderItems.AddRangeAsync(orderItems);
                            await context.SaveChangesAsync();
                        }

                        if (!context.Reviews.Any())
                        {
                            reviews = new List<Review>
                            {
                                new Review
                                {
                                    OrderId = orders[1].Id,
                                    NumberOfStars = 5,
                                    CreationTime = DateTime.Now.Subtract(TimeSpan.FromDays(10)),
                                    Description = "Wyśmienite produkty",
                                },
                            };

                            await context.Reviews.AddRangeAsync(reviews);
                            await context.SaveChangesAsync();
                        }

                        if (!context.Photos.Any())
                        {
                            var photos = new List<Photo>
                            {
                                new()
                                {
                                    Id = "xszgswvrn2pxr37zsrgl",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1639404445/xszgswvrn2pxr37zsrgl.jpg",
                                    ProductId = products[0].Id
                                },
                                new()
                                {
                                    Id = "uvlje7cxn0uimxw8ivrx",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1639404528/uvlje7cxn0uimxw8ivrx.png",
                                    ProductId = products[1].Id
                                },
                                // new()
                                // {
                                //     Id = "nwucg7h44f7h8lrt4s9c",
                                //     Url = "https://res.cloudinary.com/sbinato/image/upload/v1639404725/nwucg7h44f7h8lrt4s9c.png",
                                //     ProductId = products[2].Id
                                // },
                                new()
                                {
                                    Id = "ushymktdf4tq6txdexv1",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1639404769/ushymktdf4tq6txdexv1.jpg",
                                    ProductId = products[3].Id
                                },
                                new()
                                {
                                    Id = "l88glrdgclsswjpwaxxj",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1639404598/l88glrdgclsswjpwaxxj.jpg",
                                    ProductId = products[4].Id
                                },
                                new()
                                {
                                    Id = "bdy3gqhtpz84cd4mtse0",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1640207437/bdy3gqhtpz84cd4mtse0.jpg",
                                    ProductId = products[5].Id
                                },
                                new()
                                {
                                    Id = "w5rj9szeeudean1hetvs",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1640207405/w5rj9szeeudean1hetvs.jpg",
                                    ProductId = products[6].Id
                                },
                                new()
                                {
                                    Id = "dk6rbhsevefwqac2jhjk",
                                    Url =
                                        "https://res.cloudinary.com/sbinato/image/upload/v1640207346/dk6rbhsevefwqac2jhjk.jpg",
                                    ProductId = products[7].Id
                                },
                            };
                            await context.Photos.AddRangeAsync(photos);
                            await context.SaveChangesAsync();
                        }
                    }

                    if (!context.Coupons.Any())
                    {
                        coupons = new List<Coupon>
                        {
                            new Coupon
                            {
                                VendorId = vendors[0].Id,
                                Code = "SBIN20",
                                Amount = 20,
                                Description = "Kupon na 20% zniżki dla 100 pierwszych osób",
                                AmountOfUses = 100
                            }
                        };

                        await context.Coupons.AddRangeAsync(coupons);
                        await context.SaveChangesAsync();
                    }
                }
            }
        }
    }
}