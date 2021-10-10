using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class OrderItemFaker
    {
        public static Faker<OrderItem> Create(List<Order> orders, List<Product> products)
        {
            return new Faker<OrderItem>()
                .RuleFor(x => x.OrderId, f => f.PickRandom(orders).Id)
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id);
        }
    }
}