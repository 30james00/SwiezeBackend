using System;
using System.Threading.Tasks;
using Application.Carts.CreateCartItem;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;
    
    public class CreateCartItemTests : TestBase
    {
        [Test]
        public async Task CreateCartItem()
        {
            await SeedAsync();
            await RunAsClientUserAsync();
            
            var query = new CreateCartItemCommand(Guid.Parse("00000004-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();
            
            result.IsSuccess.Should().BeTrue();
            check.Should().Be(6);
        }        

        
        [Test]
        public async Task CreateCartItemExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new CreateCartItemCommand(Guid.Parse("00000004-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Product already in Cart");
        }
        
        [Test]
        public async Task CreateCartItem_NonExistingProduct()
        {
            await SeedAsync();
            await RunAsClientUserAsync();
            
            var query = new CreateCartItemCommand(Guid.Parse("00000010-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();
            
            result.IsSuccess.Should().BeFalse();
            check.Should().Be(5);
        }
        
        [Test]
        public async Task CreateCartItem_TooManyExistingProduct()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var query = new CreateCartItemCommand(Guid.Parse("00000004-0000-0000-0000-000000000000"), 1000);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Not enough units in stock");
            check.Should().Be(5);
        }
    }
}