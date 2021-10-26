using System.Threading.Tasks;
using Application.Categories;
using Application.Core;
using Application.Products;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.Categories
{
    using static Testing;

    public class DetailCategoryTests : TestBase
    {
        private readonly Category _category = new Category
        {
          Id = GuidHelper.ToGuid(1),
          Name = "Test",
          Description = "Test"
        };
        
        [Test]
        public async Task DetailExistingProduct()
        {
            await AddAsync(_category);

            var query = new DetailCategoryQuery(GuidHelper.ToGuid(1));

            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<CategoryDto>();
            result.Value.Name.Should().Be("Test");
            result.Value.Description.Should().Be("Test");
        }

        [Test]
        public async Task DetailNonExistingProduct()
        {
            var query = new DetailCategoryQuery(GuidHelper.ToGuid(1));
            var result = await SendAsync(query);
            result.Should().BeOfType<ApiResult<CategoryDto>>();
            result.Value.Should().BeNull();
        }
    }
}