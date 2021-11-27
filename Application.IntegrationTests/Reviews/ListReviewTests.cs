using System.Threading.Tasks;
using Application.Core;
using Application.Reviews;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Reviews
{
    using static Testing;

    public class ListReviewTests : TestBase
    {
        private readonly ListReviewQuery _query = new ListReviewQuery(new ReviewParams(), new SortingParams());

        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
        }

        [Test]
        public async Task ListClientReviews()
        {
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var result = await SendAsync(_query);

            result.Value.Should().BeOfType<PagedList<ReviewDto>>();
            result.Value.Count.Should().Be(2);
        }

        [Test]
        public async Task ListVendorReviews()
        {
            await LogInAsUserAsync("Makayla_Gleichner@hotmail.com");

            var result = await SendAsync(_query);

            result.Value.Should().BeOfType<PagedList<ReviewDto>>();
            result.Value.Count.Should().Be(2);
        }

        [Test]
        public async Task ListClientReviewsWithStarFilter()
        {
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");

            var result =
                await SendAsync(new ListReviewQuery(new ReviewParams { NumberOfStars = 5 }, new SortingParams()));

            result.Value.Should().BeOfType<PagedList<ReviewDto>>();
            result.Value.Count.Should().Be(1);
        }
        
        [Test]
        public async Task ListEmptyReviews()
        {
            await ResetState();
            await RunAsClientUserAsync();
            
            var result = await SendAsync(_query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ReviewDto>>();
            result.Value.Should().HaveCount(0);
        }
    }
}