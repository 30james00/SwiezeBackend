using System;
using Application.Contacts;
using Domain;
using FluentAssertions;
using Persistence;
using Persistence.Faker;
using Xunit;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class GetContactTests : IClassFixture<Testing>
    {
        [Fact]
        public async void GetExistingContact()
        {
            var fakeContact = ContactFaker.Create().Generate();

            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var query = new GetContact.Query(fakeContactId);

            var result = await SendAsync(query);

            result.Should().BeOfType<Contact>();
            result.Should().BeEquivalentTo(fakeContact);
        }
    }
}