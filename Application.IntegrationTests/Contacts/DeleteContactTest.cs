using System.Threading.Tasks;
using Application.Contacts;
using Application.Core;
using Domain;
using FluentAssertions;
using MediatR;
using NUnit.Framework;
using Persistence;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class DeleteContactTest : TestBase
    {
        [Test]
        public async Task DeleteExistingContact()
        {
            var fakeContact = ContactFaker.Create().Generate();
            var fakeContactId = (await AddAsync(fakeContact)).Id;

            var command = new DeleteContact.Command(fakeContactId);
            var result = await SendAsync(command);

            var check = await FindAsync<Contact>(fakeContactId);

            result.Should().BeOfType<ApiResult<Unit>>();

            check.Should().BeNull();
        }

        [Test]
        public async Task DeleteNonExistingContact()
        {
            var command = new DeleteContact.Command(GuidHelper.ToGuid(1));
            var result = await SendAsync(command);

            result.Should().BeNull();
        }
    }
}