using Application.Contacts;
using Domain;
using FluentAssertions;
using Persistence.Faker;
using Xunit;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;
    
    public class CreateContactTests: TestBase
    {
        [Fact]
        public async void CreateNewContact()
        {
            var fakeContact = ContactFaker.Create(1).Generate();

            var command = new CreateContact.Command(fakeContact);

            var result = await SendAsync(command);

            var contact = await FindAsync<Contact>(result.Id);

            contact.Should().BeOfType<Contact>();
            contact.Should().BeEquivalentTo(fakeContact);
        }
    }
}