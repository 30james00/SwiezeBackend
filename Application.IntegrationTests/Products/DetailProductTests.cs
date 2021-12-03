using System;
using System.Threading.Tasks;
using Application.Contacts;
using Application.Core;
using Application.Products;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Products
{
    using static Testing;
    
    public class DetailProductTests : TestBase
    {
        [Test]
        public async Task DetailExistingProduct()
        {
            await SeedAsync();

            var query = new DetailProductQuery(Guid.Parse("00000001-0000-0000-0000-000000000000"));

            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<ProductDto>();
            result.Value.Name.Should().Be("Keyboard");
        }

        [Test]
        public async Task DetailNonExistingProduct()
        {
            var query = new DetailProductQuery(GuidHelper.ToGuid(1));
            var result = await SendAsync(query);
            result.Should().BeOfType<ApiResult<ProductDto>>();
            result.Value.Should().BeNull();
        }
    }
}