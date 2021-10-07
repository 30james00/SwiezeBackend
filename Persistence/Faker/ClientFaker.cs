using System.Collections.Generic;
using Bogus;
using Domain;

namespace Persistence.Faker
{
    public class ClientFaker
    {
        public static Faker<Client> Create()
        {
            return new Faker<Client>()
                .RuleFor(x => x.Name, f => f.Person.FirstName)
                .RuleFor(x => x.Surname, f => f.Person.LastName);
        }

        public static Faker<Client> CreateWithAccount(int idx, List<Account> accounts)
        {
            return Create()
                .RuleFor(o => o.Id, f => GuidHelper.ToGuid(idx))
                .RuleFor(o => o.AccountId, f => accounts[idx++ - 1].Id);
        }
    }
}