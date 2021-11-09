using System;
using System.Threading.Tasks;
using Application.Carts.AddToCart;
using Application.Carts.RemoveFromCart;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;
    
    public class RemoveFromCartTests : TestBase
    {
        [Test]
        public async Task DeleteExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new RemoveFromCartCommand(Guid.Parse("00000005-0000-0000-0000-000000000000"), 2);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeTrue();
            check.Should().Be(4);
        }
        
        [Test]
        public async Task RemoveExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new RemoveFromCartCommand(Guid.Parse("00000005-0000-0000-0000-000000000000"), 1);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeTrue();
            check.Should().Be(5);
        }
        
        [Test]
        public async Task RemoveTooMuchExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new RemoveFromCartCommand(Guid.Parse("00000005-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Not enough units in Cart");
            check.Should().Be(5);
        }
        
        [Test]
        public async Task RemoveNonExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new RemoveFromCartCommand(Guid.Parse("00000004-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Not enough units in Cart");
            check.Should().Be(5);
        }
    }
}