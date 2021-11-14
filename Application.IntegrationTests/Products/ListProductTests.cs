using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Products;
using FluentAssertions;
using NUnit.Framework;

namespace Application.IntegrationTests.Products
{
    using static Testing;

    public class ListProductTests : TestBase
    {
        private readonly ListProductQuery _listProductQuery =
            new(new ProductParams(), new SortingParams());

        [SetUp]
        public async Task SetUp()
        {
            await SeedAsync();
        }

        [Test]
        public async Task ListExistingProducts()
        {
            var result = await SendAsync(_listProductQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(10);
        }

        [Test]
        public async Task ListWithValueFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { MinValue = 200, MaxValue = 400 }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(2);
        }

        [Test]
        public async Task ListWithUnitFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { MaxUnit = 100 }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(2);
        }

        [Test]
        public async Task ListWithCategoryFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { Category = Guid.Parse("391c1193-0b16-d461-21ea-f616c65f3fe2") }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(4);
        }

        [Test]
        public async Task ListWithNameFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { Name = "Gloves" }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(3);
        }

        [Test]
        public async Task ListEmptyProducts()
        {
            await ResetState();
            
            var result = await SendAsync(_listProductQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(0);
        }
    }
}