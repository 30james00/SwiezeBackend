using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class CartFaker
    {
        public static Faker<Cart> Create(List<Client> clients, List<Product> products)
        {
            return new Faker<Cart>()
                .RuleFor(x=>x.Id, f=>f.Random.Guid())
                .RuleFor(x => x.Amount, f => f.Random.Int(1, 10))
                .RuleFor(x => x.ClientId, f => f.PickRandom(clients).Id)
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id);
        }
    }
}