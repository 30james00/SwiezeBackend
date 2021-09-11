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

    public class GetContactTests : TestBase
    {
        [Fact]
        public async void GetExistingContact()
        {
            var fakeContact = ContactFaker.Create(1).Generate();

            await AddAsync(fakeContact);

            var query = new GetContact.Query(GuidHelper.ToGuid(1));

            var result = await SendAsync(query);

            result.Should().BeOfType<Contact>();
            result.Should().BeEquivalentTo(fakeContact);
        }
    }
}