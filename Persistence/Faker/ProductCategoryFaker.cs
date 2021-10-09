using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class ProductCategoryFaker
    {
        public static Faker<ProductCategory> Create(List<Product> products, List<Category> categories)
        {
            return new Faker<ProductCategory>()
                .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id)
                .RuleFor(x => x.CategoryId, f => f.PickRandom(categories).Id);
        }
    }
}