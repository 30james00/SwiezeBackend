using System;
using System.Threading.Tasks;
using Application.Carts.AddToCart;
using Application.Carts.EditCartItem;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Carts
{
    using static Testing;
    
    public class EditCartItemTests : TestBase
    {
        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
        }
        
        [Test]
        public async Task EditExistingCartItem()
        {
            var query = new EditCartItemCommand(Guid.Parse("00000002-0000-0000-0000-000000000000"), 8);
            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
        }
        
        
        [Test]
        public async Task Edit_TooMuchExistingProduct()
        {
            var query = new EditCartItemCommand(Guid.Parse("00000004-0000-0000-0000-000000000000"), 1000);
            var result = await SendAsync(query);
            var check = await CountAsync<Cart>();

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Not enough units in stock");
            check.Should().Be(5);
        }
        
        [Test]
        public async Task EditNonExistingCartItem()
        {
            var query = new EditCartItemCommand(Guid.Parse("00000007-0000-0000-0000-000000000000"), 5);
            var result = await SendAsync(query);

            result.Should().BeNull();
        }
    }
}