using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;
    
    public class DeleteContactTest: TestBase
    {
        [Test]
        public async Task DeleteExistingContact()
        {
            var fakeContact = ContactFaker.Create().Generate();
            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var command = new DeleteContact.Command(fakeContactId);
            await SendAsync(command);

            var check = await FindAsync<Contact>(fakeContactId);

            check.Should().BeNull();
        }
    }
}