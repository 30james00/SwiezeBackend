using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;
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

            result.IsSuccess.Should().BeTrue();
        }
        
        [Test]
        public async Task EditNonExistingContact()
        {
            var faker = ContactFaker.Create();
            var fakeContact = faker.Generate();
            
            var command = new EditContact.Command(GuidHelper.ToGuid(1), fakeContact);
            var result = await SendAsync(command);

            result.Should().BeNull();
        }
    }
}