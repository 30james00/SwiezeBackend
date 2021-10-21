using System.Threading.Tasks;
using Application.Contacts;
using Application.Core;
using Domain;
using FluentAssertions;
using MediatR;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Contacts
{
    using static Testing;

    public class DeleteContactTest : TestBase
    {
        [Test]
        public async Task DeleteExistingContact()
        {
            var accountId = await RunAsClientUserAsync();
            var fakeContact = ContactFaker.Create().Generate();
            fakeContact.AccountId = accountId.Item1;
            await AddAsync(fakeContact);

            var command = new DeleteContactCommand();
            var result = await SendAsync(command);

            var check = await FindAsync<Contact>(fakeContact.Id);

            result.Should().BeOfType<ApiResult<Unit>>();

            check.Should().BeNull();
        }

        [Test]
        public async Task DeleteNonExistingContact()
        {
            var command = new DeleteContactCommand();
            var result = await SendAsync(command);

            result.IsSuccess.Should().BeFalse();
        }
    }
}