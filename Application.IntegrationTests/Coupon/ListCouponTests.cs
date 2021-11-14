using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Coupons;
using Application.Orders;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Coupon
{
    using static Testing;
    
    public class ListCouponTests : TestBase
    {
        private readonly ListCouponQuery _query = new ListCouponQuery(); 
        
        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
            await LogInAsUserAsync("Makayla_Gleichner@hotmail.com");
        }
        
        [Test]
        public async Task ListExistingCoupons()
        {
            var result = await SendAsync(_query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<CouponDto>>();
        }
        
        [Test]
        public async Task ListCouponsAsClient()
        {
            await LogInAsUserAsync("Agustin.Keebler93@yahoo.com");
            
            var result = await SendAsync(_query);

            result.IsForbidden.Should().BeTrue();
        }
    }
}