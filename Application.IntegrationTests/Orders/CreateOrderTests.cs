using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Orders;
using Application.Orders.CreateOrder;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Orders
{
    using static Testing;

    public class CreateOrderTests : TestBase
    {
        private readonly CreateOrderCommand _command = new CreateOrderCommand();

        [Test]
        public async Task CreateSingleOrder()
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
        public async Task CreateMultipleOrders()
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
        public async Task CreateEmptyOrder()
        {
            await SeedAsync();
            await RunAsClientUserAsync();

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Failed to add Order");
        }

        [Test]
        public async Task CreateOrderAsVendor()
        {
            await SeedAsync();
            await RunAsVendorUserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }

        [Test]
        public async Task CreateUnavailableOrder()
        {
            await SeedAsync();
            await LogInAsUserAsync("May39@yahoo.com");
            await AddAsync(new Cart
            {
                ClientId = GuidHelper.ToGuid(2),
                ProductId = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                Amount = 1000,
            });

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("One of Products is unavailable");
        }
        
        [Test]
        public async Task CreateSingleOrderWithValidCoupon()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var command = new CreateOrderCommand{CouponCode = "WITHDRAWAL"};
            
            var result = await SendAsync(command);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<OrderDto>>();
            result.Value.Count.Should().Be(1);
            result.Value[0].Items[0].Value.Should().Be(54);

            var checkOrders = await CountAsync<Order>();
            checkOrders.Should().Be(6);
            var checkOrderItems = await CountAsync<OrderItem>();
            checkOrderItems.Should().Be(11);
        }
        
        [Test]
        public async Task CreateSingleOrderWithInValidCoupon()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var command = new CreateOrderCommand{CouponCode = "WITH"};
            
            var result = await SendAsync(command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Provided Coupon is invalid");
        }
        
        [Test]
        public async Task CreateSingleOrderWithCouponForOtherVendor()
        {
            await SeedAsync();
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var command = new CreateOrderCommand{CouponCode = "COMPUTERS, COMPUTERS & BABY"};
            
            var result = await SendAsync(command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Provided Coupon does not apply to any Product");
        }
    }
}