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
            Code = "SBIN20",
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
        }

        [Test]
        public async Task CreateCouponAsClient()
        {
            await RunAsClientUserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }
        
        [Test]
        public async Task CreateExistingCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            await AddAsync(new Domain.Coupon
            {
                Amount = 20,
                Code = "SBIN20",
                Description = "Second one",
                ExpirationDate = DateTime.Today.AddDays(3),
                AmountOfUses = 10,
                VendorId = vendor.Item2
            });
            
            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Coupon with this code already exists");
        }
    }
}