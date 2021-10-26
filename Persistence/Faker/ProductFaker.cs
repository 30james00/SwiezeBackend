using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class ProductFaker
    {
        private static int index = 1;

        public static Faker<Product> Create(List<UnitType> unitTypes, List<Vendor> vendors)
        {
            index = 1;
            return new Faker<Product>()
                .RuleFor(x => x.Id, _ => GuidHelper.ToGuid(index++))
                .RuleFor(x => x.Name, f => f.Commerce.Product())
                .RuleFor(x => x.Value, f => f.Random.Int(100, 50000))
                .RuleFor(x => x.Unit, f => f.Random.Int(1, 100000))
                .RuleFor(x => x.Stock, f => f.Random.Int(1, 1000))
                .RuleFor(x => x.UnitTypeId, f => f.PickRandom(unitTypes).Id)
                .RuleFor(x => x.VendorId, f => f.PickRandom(vendors).Id);
        }
    }
}