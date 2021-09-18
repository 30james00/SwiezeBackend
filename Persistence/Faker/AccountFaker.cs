using Bogus;
using Domain;

namespace Persistence.Faker
{
    public static class AccountFaker
    {
        public static Faker<Account> Create()
        {
            return new Faker<Account>()
                .RuleFor(x => x.UserName, f => f.Person.UserName)
                .RuleFor(x => x.Email, f => f.Internet.Email());
        }
    }
}