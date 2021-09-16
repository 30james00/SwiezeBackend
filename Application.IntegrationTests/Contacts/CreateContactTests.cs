using System.Threading.Tasks;
using Application.Contacts;
using Application.Core;
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

            var contact = await FindAsync<Contact>(result.Value.Id);

            contact.Should().BeOfType<Contact>();
            contact.Should().BeEquivalentTo(fakeContact);
        }

        [Test]
        public async Task Failure_DuplicateContactId()
        {
            var fakeContact = ContactFaker.Create().Generate();

            var command = new CreateContact.Command(fakeContact);

            await SendAsync(command);
            var result = await SendAsync(command);

            result.Should().BeOfType<ApiResult<Contact>>();
            result.Error.Should().Be("Failed to create new Contact");
        }
    }
}