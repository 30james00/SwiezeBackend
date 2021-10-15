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
        private const int CartCount = 50;
        private const int CategoryCount = 10;
        private const int ClientCount = 10;
        private const int CouponCount = 20;
        private const int ReviewCount = 50;
        private const int OrderCount = 50;
        private const int OrderItemCount = 100;
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


                users.AddRange(accountFaker.GenerateBetween(AccountCount, AccountCount));

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
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

                    if (!context.Reviews.Any())
                    {
                        var reviewFaker = ReviewFaker.Create(clients, vendors);
                        reviews.AddRange(reviewFaker.GenerateBetween(ReviewCount,ReviewCount));

                        await context.Reviews.AddRangeAsync(reviews);
                        await context.SaveChangesAsync();
                    }
                }

                if (!context.Contacts.Any())
                {
                    var contactFaker = ContactFaker.CreateWithAccount(contactIndex, 0, users);
                    contacts.AddRange(contactFaker.GenerateBetween(AccountCount, AccountCount));

                    await context.Contacts.AddRangeAsync(contacts);
                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    if (!context.UnitTypes.Any())
                    {
                        unitTypes.AddRange(new[]
                        {
                            new UnitType { Name = "g" },
                            new UnitType { Name = "ml" },
                            new UnitType { Name = "unit" },
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

                    if (!context.Carts.Any())
                    {
                        var cartFaker = CartFaker.Create(clients, products);
                        carts.AddRange(cartFaker.GenerateBetween(CartCount, CartCount));

                        await context.Carts.AddRangeAsync(carts);
                        await context.SaveChangesAsync();
                    }

                    if (!context.Orders.Any())
                    {
                        var orderFaker = OrderFaker.Create(clients, vendors);
                        orders.AddRange(orderFaker.GenerateBetween(OrderCount, OrderCount));

                        await context.Orders.AddRangeAsync(orders);
                        await context.SaveChangesAsync();

                        if (!context.OrderItems.Any())
                        {
                            var orderItemFaker = OrderItemFaker.Create(orders, products);
                            orderItems.AddRange(orderItemFaker.GenerateBetween(OrderItemCount, OrderItemCount));

                            await context.OrderItems.AddRangeAsync(orderItems);
                            await context.SaveChangesAsync();
                        }
                    }

                    if (!context.Coupons.Any())
                    {
                        var couponFaker = CouponFaker.Create(vendors);
                        coupons.AddRange(couponFaker.GenerateBetween(CouponCount, CouponCount));

                        await context.Coupons.AddRangeAsync(coupons);
                        await context.SaveChangesAsync();
                    }
                }
            }
        }
    }
}