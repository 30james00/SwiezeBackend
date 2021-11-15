using System;
using System.Threading.Tasks;
using Application.Coupons;
using Application.Coupons.EditCoupon;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Persistence;

namespace Application.IntegrationTests.Coupon
{
    using static Testing;

    public class DeleteCouponTests : TestBase
    {
        private readonly DeleteCouponCommand _command = new DeleteCouponCommand(GuidHelper.ToGuid(1));

        [Test]
        public async Task EditCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            var coupon = await AddAsync(new Domain.Coupon
            {
                Id = GuidHelper.ToGuid(1),
                Amount = 1,
                Code = "SBIN20",
                Description = "Very good coupon",
                ExpirationDate = DateTime.Today.AddDays(3),
                AmountOfUses = 30,
                VendorId = vendor.Item2
            });

            var result = await SendAsync(_command);

            result.IsSuccess.Should().BeTrue();
            var check = await FindAsync<Domain.Coupon>(coupon.Id);
            check.Should().BeNull();
        }

        [Test]
        public async Task DeleteCouponAsClient()
        {
            await RunAsClientUserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }

        [Test]
        public async Task DeleteCouponAsOtherVendor()
        {
            var vendor = await RunAsVendorUserAsync();
            await AddAsync(new Domain.Coupon
            {
                Id = GuidHelper.ToGuid(1),
                Amount = 20,
                Code = "SBIN20",
                Description = "Second one",
                ExpirationDate = DateTime.Today.AddDays(3),
                AmountOfUses = 10,
                VendorId = vendor.Item2
            });
            await RunAsVendor2UserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }

        [Test]
        public async Task DeleteNonExistingCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            await AddAsync(new Domain.Coupon
            {
                Id = GuidHelper.ToGuid(2),
                Amount = 1,
                Code = "SBIN20",
                Description = "Very good coupon",
                ExpirationDate = DateTime.Today.AddDays(3),
                AmountOfUses = 30,
                VendorId = vendor.Item2
            });

            var result = await SendAsync(_command);

            result.Should().BeNull();
        }
    }
}