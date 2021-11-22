using System.Threading.Tasks;
using Application.Reviews;
using NUnit.Framework;

namespace Application.IntegrationTests.Reviews
{
    using static Testing;
    
    public class ListReviewTests : TestBase
    {
        private readonly ListReviewQuery _query = new ListReviewQuery();
        
        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
        }

        [Test]
        public async Task ListClientReviews()
        {
            await LogInAsUserAsync("");

            await SendAsync(_query);
        }
    }
}