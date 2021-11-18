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
        public static async Task SeedData(DataContext context, UserManager<Account> userManager, bool isCompact)
        {
            Randomizer.Seed = new Random(58177474);

            var cartCount = isCompact ? 5 : 50;
            var categoryCount = isCompact ? 2 : 10;
            var clientCount = isCompact ? 2 : 10;
            var couponCount = isCompact ? 4 : 20;
            var reviewCount = isCompact ? 4 : 50;
            var orderCount = isCompact ? 5 : 50;
            var orderItemCount = isCompact ? 10 : 100;
            var productCount = isCompact ? 10 : 100;
            var vendorCount = isCompact ? 2 : 10;

            //private const int ContactCount = ClientCount + VendorCount;
            var accountCount = clientCount + vendorCount;

            var clientIndex = 1;
            var contactIndex = 1;
            var vendorIndex = 1+clientCount;

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


                users.AddRange(accountFaker.GenerateBetween(accountCount, accountCount));

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }


                if (!context.Clients.Any())
                {
                    var clientFaker = ClientFaker.CreateWithAccount(clientIndex, users);

                    clients.AddRange(clientFaker.GenerateBetween(clientCount, clientCount));

                    await context.Clients.AddRangeAsync(clients);
                    await context.SaveChangesAsync();
                }

                if (!context.Vendors.Any())
                {
                    var vendorFaker = VendorFaker.CreateWithAccount(vendorIndex, users);

                    vendors.AddRange(vendorFaker.GenerateBetween(vendorCount, vendorCount));

                    await context.Vendors.AddRangeAsync(vendors);
                    await context.SaveChangesAsync();

                    if (!context.Reviews.Any())
                    {
                        var reviewFaker = ReviewFaker.Create(orders);
                        reviews.AddRange(reviewFaker.GenerateBetween(reviewCount, reviewCount));

                        await context.Reviews.AddRangeAsync(reviews);
                        await context.SaveChangesAsync();
                    }
                }

                if (!context.Contacts.Any())
                {
                    var contactFaker = ContactFaker.CreateWithAccount(contactIndex, 0, users);
                    contacts.AddRange(contactFaker.GenerateBetween(accountCount, accountCount));

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
                            new UnitType { Id = GuidHelper.ToGuid(3), Name = "unit" },
                        });

                        await context.UnitTypes.AddRangeAsync(unitTypes);
                        await context.SaveChangesAsync();
                    }

                    var productFaker = ProductFaker.Create(unitTypes, vendors);
                    products.AddRange(productFaker.GenerateBetween(productCount, productCount));

                    await context.Products.AddRangeAsync(products);
                    await context.SaveChangesAsync();

                    if (!context.Categories.Any())
                    {
                        var categoryFaker = CategoryFaker.Create();
                        categories.AddRange(categoryFaker.GenerateBetween(categoryCount, categoryCount));

                        await context.Categories.AddRangeAsync(categories);
                        await context.SaveChangesAsync();
                    }

                    if (!context.ProductCategories.Any())
                    {
                        var productCategoryFaker = ProductCategoryFaker.Create(products, categories);
                        productCategories.AddRange(productCategoryFaker.GenerateBetween(productCount, productCount));

                        await context.ProductCategories.AddRangeAsync(productCategories);
                        await context.SaveChangesAsync();
                    }

                    if (!context.Carts.Any())
                    {
                        var cartFaker = CartFaker.Create(clients, products);
                        carts.AddRange(cartFaker.GenerateBetween(cartCount, cartCount));

                        await context.Carts.AddRangeAsync(carts);
                        await context.SaveChangesAsync();
                    }

                    if (!context.Orders.Any())
                    {
                        var orderFaker = OrderFaker.Create(clients, vendors);
                        orders.AddRange(orderFaker.GenerateBetween(orderCount, orderCount));

                        await context.Orders.AddRangeAsync(orders);
                        await context.SaveChangesAsync();

                        if (!context.OrderItems.Any())
                        {
                            var orderItemFaker = OrderItemFaker.Create(orders, products);
                            orderItems.AddRange(orderItemFaker.GenerateBetween(orderItemCount, orderItemCount));

                            await context.OrderItems.AddRangeAsync(orderItems);
                            await context.SaveChangesAsync();
                        }
                    }

                    if (!context.Coupons.Any())
                    {
                        var couponFaker = CouponFaker.Create(vendors);
                        coupons.AddRange(couponFaker.GenerateBetween(couponCount, couponCount));

                        await context.Coupons.AddRangeAsync(coupons);
                        await context.SaveChangesAsync();
                    }
                }
            }
        }
    }
}