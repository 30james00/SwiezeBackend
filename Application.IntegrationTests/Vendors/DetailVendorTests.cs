using System.Threading.Tasks;
using Application.Vendor;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Vendors
{
    using static Testing;
    
    public class DetailVendorTests : TestBase
    {
        [Test]
        public async Task DetailVendor()
        {
            var vendorId = (await RunAsVendorUserAsync()).Item2;
            var query = new DetailVendorQuery(vendorId);

            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<VendorDto>();
        }

        [Test]
        public async Task DetailNonExistingVendor()
        {
            var query = new DetailVendorQuery(GuidHelper.ToGuid(1));

            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeNull();
        }
    }
}