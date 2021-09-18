using Bogus;
using Domain;

namespace Persistence.Faker
{
    public static class ContactFaker
    {
        public static Faker<Contact> Create()
        {
            return new Faker<Contact>()
                .RuleFor(o => o.Mail, f => f.Internet.Email())
                .RuleFor(o => o.Phone, f => f.Random.Int(111111111, 999999999).ToString())
                .RuleFor(o => o.Voivodeship, f => f.Address.State())
                .RuleFor(o => o.PostalCode, f => $"{f.Random.String(2, 2, '0', '9')}-{f.Random.String(3, 3, '0', '9')}")
                .RuleFor(o => o.City, f => f.Address.City())
                .RuleFor(o => o.Street, f => f.Address.StreetName())
                .RuleFor(o => o.HouseNumber, f => f.Address.BuildingNumber())
                .RuleFor(o => o.FlatNumber, f => $"{f.Random.String(1, 3, '0', '9')}{f.Random.String(0, 1, 'A', 'Z')}");
        }

        public static Faker<Contact> CreateWithId(int contactIndex)
        {
            return Create()
                .RuleFor(o => o.Id, f => GuidHelper.ToGuid(contactIndex++));
        }
    }
}