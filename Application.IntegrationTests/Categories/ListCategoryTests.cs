using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Categories;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.IntegrationTests.Categories
{
    using static Testing;

    public class ListCategoryTests : TestBase
    {
        private readonly ListCategoryQuery _listCategoryQuery = new ListCategoryQuery();

        [Test]
        public async Task ListExistingCategories()
        {
            var categoryFaker = CategoryFaker.Create();
            for (var i = 0; i < 3; i++)
            {
                var category = categoryFaker.Generate();
                await AddAsync(category);
            }

            var result = await SendAsync(_listCategoryQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<CategoryDto>>();
            result.Value.Should().HaveCount(3);
        }

        [Test]
        public async Task ListEmptyCategories()
        {
            var result = await SendAsync(_listCategoryQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<CategoryDto>>();
            result.Value.Should().HaveCount(0);
        }
    }
}