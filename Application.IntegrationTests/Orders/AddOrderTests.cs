using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Orders;
using Application.Orders.AddOrder;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Orders
{
    using static Testing;

    public class AddOrderTests : TestBase
    {
        private readonly AddOrderCommand _command = new AddOrderCommand();

        [Test]
        public async Task AddSingleOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<OrderDto>>();
            result.Value.Count.Should().Be(1);

            var checkOrders = await CountAsync<Order>();
            checkOrders.Should().Be(6);
            var checkOrderItems = await CountAsync<OrderItem>();
            checkOrderItems.Should().Be(11);
        }

        [Test]
        public async Task AddMultipleOrders()
        {
            await SeedAsync();
            await LogInAsUserAsync("May39@yahoo.com");

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<OrderDto>>();
            result.Value.Count.Should().Be(2);

            var checkOrders = await CountAsync<Order>();
            checkOrders.Should().Be(7);
            var checkOrderItems = await CountAsync<OrderItem>();
            checkOrderItems.Should().Be(14);
        }

        [Test]
        public async Task AddEmptyOrder()
        {
            await SeedAsync();
            await RunAsClientUserAsync();

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Failed to add Order");
        }

        [Test]
        public async Task AddOrderAsVendor()
        {
            await SeedAsync();
            await RunAsVendorUserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }

        [Test]
        public async Task AddUnavailableOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("May39@yahoo.com");
            await AddAsync<Cart>(new Cart
            {
                ClientId = GuidHelper.ToGuid(2),
                ProductId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                Amount = 1000,
            });

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("One of Products is unavailable");
        }
    }
}