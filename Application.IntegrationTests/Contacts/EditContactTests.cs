using System.Threading.Tasks;
using Application.Contacts;
using Application.Contacts.EditContact;
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
        private EditContact.Command command = new EditContact.Command
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
        public async Task EditExistingContact()
        {
            var accountId = await RunAsClientUserAsync();
            var faker = ContactFaker.Create();
            var fakeContact = faker.Generate();
            fakeContact.AccountId = accountId;

            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var result = await SendAsync(command);

            var check = await FindAsync<Contact>(fakeContactId);
            
            check.Should().BeOfType<Contact>();
            check.Should().BeEquivalentTo(command);

            result.IsSuccess.Should().BeTrue();
        }
        
        [Test]
        public async Task EditNonExistingContact()
        {
            var faker = ContactFaker.Create();
            var fakeContact = faker.Generate();
            
            var result = await SendAsync(command);

            result.Should().BeNull();
        }
    }
}