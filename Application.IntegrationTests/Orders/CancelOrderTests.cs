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
        [Test]
        public async Task CancelExistingOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
            
            var command = new CancelOrderCommand(Guid.Parse("6c321135-79bb-4d33-a840-89d5126ed9f3"));
            var result = await SendAsync(command);
            var check = await FindAsync<Order>(result.Value.Id);

            result.IsSuccess.Should().BeTrue();
            check.IsCanceled.Should().BeTrue();
        }
    }
}