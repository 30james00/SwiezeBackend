using System;
using System.Threading.Tasks;
using Application.Orders;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Orders
{
    using static Testing;
    
    public class CancelOrderTests: TestBase
    {
        private readonly Guid _id = Guid.Parse("19fe6067-d019-dbcf-ab00-672b07f847d4");
        
        [Test]
        public async Task CancelExistingOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Carey16@yahoo.com");
            
            var command = new CancelOrderCommand(_id);
            var result = await SendAsync(command);
            
            result.IsSuccess.Should().BeTrue();

            var check = await FindAsync<Order>(result.Value.Id);
            check.IsCanceled.Should().BeTrue();
        }
        
        [Test]
        public async Task CancelExistingOrderAsClient()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
            
            var command = new CancelOrderCommand(_id);
            var result = await SendAsync(command);
            
            result.IsForbidden.Should().BeTrue();
        }
        
        [Test]
        public async Task CancelNonExistingOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Carey16@yahoo.com");
            
            var command = new CancelOrderCommand(Guid.Parse("fea34ec8-cffc-0000-59d6-5d72cfdfd4d0"));
            var result = await SendAsync(command);
            
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Order does not exist");
        }
    }
}