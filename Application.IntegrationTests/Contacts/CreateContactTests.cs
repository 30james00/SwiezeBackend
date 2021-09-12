using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class CreateContactTests : TestBase
    {
        [Test]
        public async Task CreateNewContact()
        {
            var fakeContact = ContactFaker.Create().Generate();

            var command = new CreateContact.Command(fakeContact);

            var result = await SendAsync(command);

            var contact = await FindAsync<Contact>(result.Id);

            contact.Should().BeOfType<Contact>();
            contact.Should().BeEquivalentTo(fakeContact);
        }
    }
}