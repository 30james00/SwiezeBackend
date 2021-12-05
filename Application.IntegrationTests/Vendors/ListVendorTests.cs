using System.Threading.Tasks;
using Application.Core;
using Application.Vendor;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Vendors
{
    using static Testing;
    
    public class ListVendorTests : TestBase
    {
        private readonly ListVendorQuery _query = new ListVendorQuery(new PagingParams());
        
        [Test]
        public async Task ListVendor()
        {
            await RunAsVendorUserAsync();
            await RunAsVendor2UserAsync();

            var result = await SendAsync(_query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<VendorDto>>();
            result.Value.Count.Should().Be(2);
        }
        
        [Test]
        public async Task ListVendorEmpty()
        {
            var result = await SendAsync(_query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<VendorDto>>();
            result.Value.Count.Should().Be(0);
        }
    }
}