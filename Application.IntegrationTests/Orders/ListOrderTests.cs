using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Orders;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Orders
{
    using static Testing;
    
    public class ListOrderTests : TestBase
    {
        private readonly ListOrderQuery _query = new ListOrderQuery(new OrderParams(), new SortingParams());
        
        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
        }
        
        [Test]
        public async Task ListExistingOrders()
        {
            var result = await SendAsync(_query);

            result.Value.Count.Should().Be(4);
            result.Value.Should().BeOfType<PagedList<OrderDto>>();
        }
        
        [Test]
        public async Task ListExistingOrders_OrderDateFilter()
        {
            var query = new ListOrderQuery(new OrderParams
            {
                MinOrderDate = new DateTime(2020, 7, 1),
                MaxOrderDate = new DateTime(2020, 9, 1)
            }, new SortingParams());
            
            var result = await SendAsync(query);

            result.Value.Count.Should().Be(2);
            result.Value.Should().BeOfType<PagedList<OrderDto>>();
        }

        [Test] public async Task ListExistingOrders_FulfillmentDateFilter()
        {
            var query = new ListOrderQuery(new OrderParams
            {
                MinFulfillmentDate = new DateTime(2020, 3, 1),
                MaxFulfillmentDate = new DateTime(2020, 5, 1)
            }, new SortingParams());
            
            var result = await SendAsync(query);

            result.Value.Count.Should().Be(2);
            result.Value.Should().BeOfType<PagedList<OrderDto>>();
        }
    }
}