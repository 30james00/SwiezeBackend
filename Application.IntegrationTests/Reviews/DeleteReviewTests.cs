using System;
using System.Threading.Tasks;
using Application.Reviews;
using Application.Reviews.EditReview;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Reviews
{
    using static Testing;
    
    public class DeleteReviewTests : TestBase
    {
        [Test]
        public async Task DeleteReview()
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

            var review = new Review
            {
                OrderId = order.Id,
                NumberOfStars = 5,
                CreationTime = DateTime.Now,
                Description = "sbin"
            };

            await AddAsync(review);

            var command = new DeleteReviewCommand(review.Id);

            var result = await SendAsync(command);
            result.IsSuccess.Should().BeTrue();
        }        
        
        [Test]
        public async Task DeleteReviewAsOtherUser()
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

            var review = new Review
            {
                OrderId = order.Id,
                NumberOfStars = 5,
                CreationTime = DateTime.Now,
                Description = "sbin"
            };

            await AddAsync(review);

            await RunAsClient2UserAsync();

            var command = new DeleteReviewCommand(review.Id);

            var result = await SendAsync(command);
            result.IsForbidden.Should().BeTrue();
        }
    }
}