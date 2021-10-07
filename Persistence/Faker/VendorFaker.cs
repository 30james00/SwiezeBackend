using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class VendorFaker
    {
        public static Faker<Vendor> Create()
        {
            return new Faker<Vendor>()
                .RuleFor(o => o.Name, f => f.Company.CompanyName());
        }

        public static Faker<Vendor> CreateWithAccount(int idx, List<Account> accounts)
        {
            return Create()
                .RuleFor(o => o.Id, f => GuidHelper.ToGuid(idx))
                .RuleFor(o => o.AccountId, f => accounts[idx++ - 1].Id);
        }
    }
}