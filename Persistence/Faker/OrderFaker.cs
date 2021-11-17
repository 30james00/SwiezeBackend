using System;
using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class OrderFaker
    {
        public static Faker<Order> Create(List<Client> clients, List<Vendor> vendors)
        {
            return new Faker<Order>()
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.OrderDate, f => f.Date.Past(2, new DateTime(2021, 12, 31)))
                .RuleFor(x => x.FulfillmentDate,
                    f => f.Random.Bool() ? f.Date.Past(2, new DateTime(2021, 12, 31)) : null)
                .RuleFor(x => x.ClientId, f => f.PickRandom(clients).Id)
                .RuleFor(x => x.VendorId, f => f.PickRandom(vendors).Id)
                .RuleFor(x => x.IsCanceled, f => !(f.Random.Float() <= 0.9));
        }
    }
}