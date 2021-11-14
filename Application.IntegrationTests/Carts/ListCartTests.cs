using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Carts;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;

    public class ListCartTests : TestBase
    {
        private readonly ListCartQuery _query = new ListCartQuery();

        [Test]
        public async Task ListCart_Success()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var result = await SendAsync(_query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<CartDto>>();
            result.Value.Count.Should().Be(1);
        }
    }
}