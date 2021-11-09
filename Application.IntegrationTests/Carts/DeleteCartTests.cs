using System.Threading.Tasks;
using Application.Carts;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;

    public class DeleteCartTests : TestBase
    {
        private readonly DeleteCartCommand _command = new DeleteCartCommand();

        [Test]
        public async Task DeleteExistingCart()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var result = await SendAsync(_command);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeTrue();
            check.Should().Be(3);
        }
        
        [Test]
        public async Task DeleteNonExistingCart()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            await SendAsync(_command);
            var result = await SendAsync(_command);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeTrue();
            check.Should().Be(3);
        }
    }
}