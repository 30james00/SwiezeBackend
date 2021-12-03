using System;
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
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.OrderId, f => f.PickRandom(orders).Id)
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id)
                .RuleFor(x => x.Amount, f => f.Random.Int(1, 100))
                .RuleFor(x => x.Value, f => Convert.ToInt32(f.Random.Int(1, 10) * Math.Pow(10, f.Random.Int(1, 6))));
        }
    }
}