using Application.Contacts;
using Domain;
using FluentAssertions;
using Persistence.Faker;
using Xunit;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;
    
    public class CreateContactTests: IClassFixture<Testing>
    {
        [Fact]
        public async void CreateNewContact()
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