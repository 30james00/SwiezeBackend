using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class EditContactTests : TestBase
    {
        [Test]
        public async Task EditExistingContact()
        {
            var faker = ContactFaker.Create();
            var fakeContact = faker.Generate();
            var editedContact = faker.Generate();

            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var command = new EditContact.Command(fakeContactId, editedContact);
            var result = await SendAsync(command);

            result.Should().BeOfType<Contact>();
            result.Should().BeEquivalentTo(editedContact);
        }
    }
}