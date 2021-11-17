using System.Threading.Tasks;
using Application.Coupons;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Coupon
{
    using static Testing;

    public class ValidateCouponTests : TestBase
    {
        [Test]
        public async Task ValidateValidCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            var coupon = new Domain.Coupon
            {
                Amount = 20,
                Code = "SBIN20",
                VendorId = vendor.Item2
            };
            await AddAsync(coupon);
            await RunAsClientUserAsync();

            var query = new ValidateCouponQuery("SBIN20");
            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeEquivalentTo(coupon, opt => opt.ExcludingMissingMembers());
        }
        
        [Test]
        public async Task ValidateInValidCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            var coupon = new Domain.Coupon
            {
                Amount = 20,
                Code = "SBIN20",
                AmountOfUses = 0,
                VendorId = vendor.Item2
            };
            await AddAsync(coupon);
            await RunAsClientUserAsync();

            var query = new ValidateCouponQuery("SBIN20");
            var result = await SendAsync(query);

            result.Should().BeNull();
        }
        
        [Test]
        public async Task ValidateNonExistingCoupon()
        {
            await RunAsClientUserAsync();

            var query = new ValidateCouponQuery("SBIN20");
            var result = await SendAsync(query);

            result.Should().BeNull();
        }
    }
}