using System;
using System.Threading.Tasks;
using Application.Coupons.EditCoupon;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Coupon
{
    using static Testing;

    public class EditCouponTests : TestBase
    {
        private readonly EditCouponCommand _command = new EditCouponCommand
        {
            Id = GuidHelper.ToGuid(1),
            Amount = 20,
            Description = "Very good coupon",
            ExpirationDate = DateTime.Today.AddDays(30),
            AmountOfUses = 1000
        };

        [Test]
        public async Task EditCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            await AddAsync(new Domain.Coupon
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
            result.Value.Should().BeEquivalentTo(_command);
            var check = await FindAsync<Domain.Coupon>(result.Value.Id);
            check.Should().BeEquivalentTo(_command);
        }

        [Test]
        public async Task EditCouponAsClient()
        {
            await RunAsClientUserAsync();

            var result = await SendAsync(_command);

            result.IsForbidden.Should().BeTrue();
        }

        [Test]
        public async Task EditCouponAsOtherVendor()
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
        public async Task EditNonExistingCoupon()
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

        [Test]
        public async Task EditPartOfCoupon()
        {
            var vendor = await RunAsVendorUserAsync();
            await AddAsync(new Domain.Coupon
            {
                Id = GuidHelper.ToGuid(1),
                Amount = 1,
                Code = "SBIN20",
                Description = "Very good coupon",
                ExpirationDate = DateTime.Today.AddDays(3),
                AmountOfUses = 30,
                VendorId = vendor.Item2
            });

            var command = new EditCouponCommand
            {
                Id = GuidHelper.ToGuid(1),
                Amount = 1,
            };

            var result = await SendAsync(command);
            
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeEquivalentTo(command);
            var check = await FindAsync<Domain.Coupon>(result.Value.Id);
            check.Should().BeEquivalentTo(command);
            check.ExpirationDate.Should().BeNull();
            check.Description.Should().BeNull();
            check.AmountOfUses.Should().BeNull();
        }
    }
}