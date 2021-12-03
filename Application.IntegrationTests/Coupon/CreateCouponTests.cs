using System;
using System.Threading.Tasks;
using Application.Coupons.CreateCoupon;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Coupon
{
    using static Testing;

    public class CreateCouponTests : TestBase
    {
        private readonly CreateCouponCommand _command = new CreateCouponCommand
        {
            Amount = 20,
            Description = "Very good coupon",
            ExpirationDate = DateTime.Today.AddDays(30),
            AmountOfUses = 1000
        };

        [Test]
        public async Task CreateCoupon()
        {
            await RunAsVendorUserAsync();

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeEquivalentTo(_command);
            var check = await FindAsync<Domain.Coupon>(result.Value.Id);
            check.Should().BeEquivalentTo(_command);
            check.Code.Length.Should().Be(8);
        }

        [Test]
        public async Task CreateCouponAsClient()
        {
            await RunAsClientUserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }
    }
}