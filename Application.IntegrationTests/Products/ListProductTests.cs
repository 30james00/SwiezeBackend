using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Core;
using Application.Products;
using Bogus.Extensions;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Products
{
    using static Testing;

    public class ListProductTests : TestBase
    {
        private static readonly Domain.Vendor Vendors = VendorFaker.Create().Generate();

        private static readonly UnitType UnitTypes = new UnitType { Name = "Test" };

        private static readonly Product Products =
            ProductFaker.Create(new List<UnitType> { UnitTypes }, new List<Domain.Vendor>() { Vendors })
                .Generate();

        private readonly ListProductQuery _listProductQuery = new ListProductQuery(new PagingParams());

        [Test]
        public async Task ListExistingProducts()
        {
            await SeedAsync();

            var result = await SendAsync(_listProductQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(10);
        }

        [Test]
        public async Task ListEmptyProducts()
        {
            var result = await SendAsync(_listProductQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(0);
        }
    }
}