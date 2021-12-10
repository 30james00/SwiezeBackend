using System;
using System.Threading.Tasks;
using Application.Carts;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;

    public class DeleteCartItemTests : TestBase
    {
        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
        }
        
        [Test]
        public async Task DeleteCartItem()
        {
            var query = new DeleteCartItemCommand(Guid.Parse("00000002-0000-0000-0000-000000000000"));
            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
        }

        [Test]
        public async Task DeleteNonExistingCartItem()
        {
            var query = new DeleteCartItemCommand(Guid.Parse("00000010-0000-0000-0000-000000000000"));
            var result = await SendAsync(query);

            result.Should().BeNull();
        }
    }
}