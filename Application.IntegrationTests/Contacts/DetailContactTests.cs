using System.Threading.Tasks;
using Application.Contacts;
using Application.Core;
using Domain;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Persistence;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class DetailContactTests : TestBase
    {
        [Test]
        public async Task DetailsOfExistingContact()
        {
            var fakeContact = ContactFaker.Create().Generate();

            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var query = new DetailContactQuery(fakeContactId);

            var result = await SendAsync(query);

            result.Value.Should().BeOfType<ContactDto>();
            result.Value.Should()
                .BeEquivalentTo(fakeContact, opt => opt.ExcludingMissingMembers());
        }

        [Test]
        public async Task DetailsOfNonExistingContact()
        {
            var query = new DetailContactQuery(GuidHelper.ToGuid(1));
            var result = await SendAsync(query);
            result.Should().BeOfType<ApiResult<ContactDto>>();
            result.Value.Should().BeNull();
        }
    }
}