using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class DetailContactTests : TestBase
    {
        [Test]
        public async Task GetExistingContact()
        {
            var fakeContact = ContactFaker.Create().Generate();

            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var query = new DetailContact.Query(fakeContactId);

            var result = await SendAsync(query);

            result.Should().BeOfType<Contact>();
            result.Should().BeEquivalentTo(fakeContact);
        }
    }
}