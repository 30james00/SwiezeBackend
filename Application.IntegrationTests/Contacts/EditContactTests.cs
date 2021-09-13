using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using FluentAssertions;
using NUnit.Framework;
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

            var check = await FindAsync<Contact>(fakeContactId);

            editedContact.Id = fakeContactId;
            check.Should().BeOfType<Contact>();
            check.Should().BeEquivalentTo(editedContact);
        }
    }
}