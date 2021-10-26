using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class CategoryFaker
    {
        public static Faker<Category> Create()
        {
            return new Faker<Category>()
                .RuleFor(x => x.Id, f => f.Random.Guid())
                .RuleFor(x => x.Name, f => f.Commerce.Department())
                .RuleFor(x => x.Description, f => f.Lorem.Sentence());
        }
    }
}