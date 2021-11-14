using System;
using System.Threading.Tasks;
using Application.Orders;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Orders
{
    using static Testing;
    
    public class FulfillOrderTests: TestBase
    {
        [Test]
        public async Task FulfillExistingOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Carey16@yahoo.com");
            
            var command = new FulfillOrderCommand(Guid.Parse("fea34ec8-cffc-6aa3-59d6-5d72cfdfd4d0"));
            var result = await SendAsync(command);
            
            result.IsSuccess.Should().BeTrue();

            var check = await FindAsync<Order>(result.Value.Id);
            check.FulfillmentDate.Should().BeCloseTo(DateTime.Now, TimeSpan.FromSeconds(5));
        }
        
        [Test]
        public async Task FulfillExistingOrderAsClient()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
            
            var command = new FulfillOrderCommand(Guid.Parse("fea34ec8-cffc-6aa3-59d6-5d72cfdfd4d0"));
            var result = await SendAsync(command);
            
            result.IsForbidden.Should().BeTrue();
        }
        
        [Test]
        public async Task FulfillNonExistingOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Carey16@yahoo.com");
            
            var command = new FulfillOrderCommand(Guid.Parse("fea34ec8-cffc-0000-59d6-5d72cfdfd4d0"));
            var result = await SendAsync(command);
            
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Order does not exist");
        }
        
        [Test]
        public async Task FulfillFulfilledOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Carey16@yahoo.com");
            
            var command = new FulfillOrderCommand(Guid.Parse("b4c0c17c-b216-82ca-3ac0-4d100ceddb54"));
            var result = await SendAsync(command);
            
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Order is already fulfilled");
        }
    }
}