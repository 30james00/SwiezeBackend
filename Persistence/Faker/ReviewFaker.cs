using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class ReviewFaker
    {
        public static Faker<Review> Create(List<Client> clients, List<Vendor> vendors)
        {
            return new Faker<Review>()
                .RuleFor(x => x.NumberOfStars, f => f.Random.Int(1, 5))
                .RuleFor(x => x.Description, f => f.Random.Bool() ? f.Lorem.Sentences(2) : null)
                .RuleFor(x => x.ClientId, f => f.PickRandom(clients).Id)
                .RuleFor(x => x.VendorId, f => f.PickRandom(vendors).Id);
        }
    }
}