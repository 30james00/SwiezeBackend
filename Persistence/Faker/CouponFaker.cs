using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class CouponFaker
    {
        public static Faker<Coupon> Create(List<Vendor> vendors)
        {
            return new Faker<Coupon>()
                .RuleFor(x => x.Code, f => f.Random.Word().ToUpper())
                .RuleFor(x => x.Amount, f => f.Random.Int(5, 50))
                .RuleFor(x => x.Description, f => f.Random.Bool() ? f.Commerce.ProductDescription() : null)
                .RuleFor(x => x.AmountOfUses, f => f.Random.Bool() ? f.Random.Int(1, 100) : null)
                .RuleFor(x => x.ExpirationDate, f => f.Random.Bool() ? f.Date.Future() : null)
                .RuleFor(x => x.VendorId, f => f.PickRandom(vendors).Id);
        }
    }
}