using System;
using System.Threading.Tasks;
using Application.Reviews.EditReview;
using Domain;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Reviews
{
    using static Testing;
    
    public class EditReviewTests : TestBase 
    {
        [Test]
        public async Task EditReview()
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

            var command = new EditReviewCommand
            {
                Id = review.Id,
                NumberOfStars = 4,
            };

            var result = await SendAsync(command);
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeEquivalentTo(command, o => o.ExcludingMissingMembers());

            var check = await FindAsync<Review>(result.Value.Id);
            check.Should().BeEquivalentTo(command, o => o.ExcludingMissingMembers());
            check.Description.Should().BeNull();
        }        
        
        [Test]
        public async Task EditReviewAsOtherUser()
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

            var command = new EditReviewCommand
            {
                Id = review.Id,
                NumberOfStars = 4,
            };

            var result = await SendAsync(command);
            result.IsForbidden.Should().BeTrue();
        }
    }
}