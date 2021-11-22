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
            result.Value.Should().HaveCount(1);
        }

        [Test]
        public async Task ListWithUnitFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { MaxUnit = 100 }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(3);
        }

        [Test]
        public async Task ListWithCategoryFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { Category = Guid.Parse("fd1d78fe-4519-f216-0e16-dd8ef1e3bcea") }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(3);
        }

        [Test]
        public async Task ListWithNameFilter()
        {
            var result = await SendAsync(new ListProductQuery(new ProductParams
                { Name = "Keyboard" }, new SortingParams()));

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<PagedList<ProductDto>>();
            result.Value.Should().HaveCount(1);
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