using System;
using System.Threading.Tasks;
using Application.Reviews.CreateReview;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Reviews
{
    using static Testing;
    
    public class CreateReviewTests : TestBase
    {
        [Test]
        public async Task CreateReview()
        {
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            var clientId = (await RunAsClientUserAsync()).Item2;
            
            var order = new Order
            {
                OrderDate = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                FulfillmentDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                ClientId = clientId,
                VendorId = vendorId,
            };

            await AddAsync(order);

            var command = new CreateReviewCommand
            {
                OrderId = order.Id,
                NumberOfStars = 5,
            };

            var result = await SendAsync(command);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeEquivalentTo(command, o => o.ExcludingMissingMembers());

            var check = FindAsync<Review>(result.Value.Id);
            check.Result.Should().BeEquivalentTo(command, o => o.ExcludingMissingMembers());
            check.Result.CreationTime.Should().BeCloseTo(DateTime.Now, TimeSpan.FromSeconds(5));
        }

        [Test]
        public async Task CreateReviewAsVendor()
        {
            var clientId = (await RunAsClientUserAsync()).Item2;
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            
            var order = new Order
            {
                OrderDate = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                FulfillmentDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                ClientId = clientId,
                VendorId = vendorId,
            };

            await AddAsync(order);

            var command = new CreateReviewCommand
            {
                OrderId = order.Id,
                NumberOfStars = 5,
            };

            var result = await SendAsync(command);

            result.IsForbidden.Should().BeTrue();
        }
        [Test]
        public async Task CreateReviewAsNotOwner()
        {
            var clientId = (await RunAsClientUserAsync()).Item2;
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            
            var order = new Order
            {
                OrderDate = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                FulfillmentDate = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                ClientId = clientId,
                VendorId = vendorId,
            };

            await AddAsync(order);

            await RunAsClient2UserAsync();

            var command = new CreateReviewCommand
            {
                OrderId = order.Id,
                NumberOfStars = 5,
            };

            var result = await SendAsync(command);

            result.IsForbidden.Should().BeTrue();
        }
        
        [Test]
        public async Task CreateReviewOfUnfulfilledOrder()
        {
            var clientId = (await RunAsClientUserAsync()).Item2;
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            
            var order = new Order
            {
                OrderDate = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                ClientId = clientId,
                VendorId = vendorId,
            };

            await AddAsync(order);

            var command = new CreateReviewCommand
            {
                OrderId = order.Id,
                NumberOfStars = 5,
            };

            var result = await SendAsync(command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Order is not fulfilled yet");
        }
    }
}