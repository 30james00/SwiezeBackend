using System;
using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class ReviewFaker
    {
        public static Faker<Review> Create(int orderIndex, List<Order> orders)
        {
            return new Faker<Review>()
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.CreationTime, f => f.Date.Past(2, new DateTime(2021, 11, 1)))
                .RuleFor(x => x.NumberOfStars, f => f.Random.Int(1, 5))
                .RuleFor(x => x.Description, f => f.Random.Bool() ? f.Lorem.Sentences(2) : null)
                .RuleFor(x => x.OrderId, _ => orders[orderIndex++].Id);
        }
    }
}