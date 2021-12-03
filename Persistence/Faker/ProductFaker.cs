using System;
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
                .RuleFor(x => x.Value, f => Convert.ToInt32(f.Random.Int(1, 10) * Math.Pow(10, f.Random.Int(1, 4))))
                .RuleFor(x => x.Unit, f => Convert.ToInt32(f.Random.Int(1, 10) * Math.Pow(10, f.Random.Int(1, 6))))
                .RuleFor(x => x.Stock, f => f.Random.Int(1, 1000))
                .RuleFor(x => x.UnitTypeId, f => f.PickRandom(unitTypes).Id)
                .RuleFor(x => x.VendorId, f => f.PickRandom(vendors).Id);
        }
    }
}