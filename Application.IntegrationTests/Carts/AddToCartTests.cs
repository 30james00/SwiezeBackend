using System;
using System.Threading.Tasks;
using Application.Carts.AddToCart;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;
    
    public class AddToCartTests : TestBase
    {
        [Test]
        public async Task AddExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new AddToCartCommand(Guid.Parse("00000005-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeTrue();
            check.Should().Be(5);
        }

        [Test]
        public async Task AddNewProduct()
        {
            await SeedAsync();
            await RunAsClientUserAsync();
            
            var query = new AddToCartCommand(Guid.Parse("00000005-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();
            
            result.IsSuccess.Should().BeTrue();
            check.Should().Be(6);
        }        
        
        [Test]
        public async Task AddNonExistingProduct()
        {
            await SeedAsync();
            await RunAsClientUserAsync();
            
            var query = new AddToCartCommand(Guid.Parse("00000010-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();
            
            result.IsSuccess.Should().BeFalse();
            check.Should().Be(5);
        }
        
        [Test]
        public async Task AddTooManyExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new AddToCartCommand(Guid.Parse("00000005-0000-0000-0000-000000000000"), 1000);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Not enough units in stock");
            check.Should().Be(5);
        }
    }
}