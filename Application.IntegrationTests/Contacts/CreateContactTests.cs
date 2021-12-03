using System.Threading.Tasks;
using Application.Contacts;
using Application.Contacts.CreateContact;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class CreateContactTests : TestBase
    {
        private CreateContactCommand command = new CreateContactCommand
        {
            Mail = "test@test.com",
            City = "Lublin",
            Phone = "+48111222333",
            Street = "Leeeeee",
            Voivodeship = "Lubelskie",
            FlatNumber = "2D",
            HouseNumber = "1A",
            PostalCode = "20-100"
        };

        [Test]
        public async Task CreateNewClientContact()
        {
            var accountId = await RunAsClientUserAsync();

            var result = await SendAsync(command);

            var contact = await FindAsync<Contact>(result.Value.Id);

            contact.Should().BeOfType<Contact>();
            contact.Should().BeEquivalentTo(command);
            contact.AccountId.Should().Be(accountId.Item1);
        }
    }
}