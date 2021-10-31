using System.Collections.Generic;
using System.Linq;
using Application.Core;
using Bogus.Extensions;
using Domain;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using NUnit.Framework;
using Persistence.Faker;

namespace Application.UnitTests.Core
{
    public class SortingParamsTests
    {
        [Test]
        public void DefaultValues()
        {
            var sortingParams = new SortingParams();

            sortingParams.SortField.Should().BeNull();
            sortingParams.SortDir.Should().Be(SortDirection.Asc);
        }

        [Test]
        public void CustomValues()
        {
            var sortingParams = new SortingParams
            {
                SortField = "test",
                SortDir = SortDirection.Desc,
            };

            sortingParams.SortField.Should().Be("test");
            sortingParams.SortDir.Should().Be(SortDirection.Desc);
        }

        [Test]
        public void GetData()
        {
            var sortingParams = new SortingParams
            {
                SortField = "name",
                SortDir = SortDirection.Desc,
            };

            var randomCategories = new List<Category>();
            var categoryFaker = CategoryFaker.Create();

            randomCategories.AddRange(categoryFaker.GenerateBetween(10, 10));

            var mock = randomCategories.AsQueryable().BuildMock();

            var result = sortingParams.GetData(mock.Object).AsEnumerable();

            result.Should().NotBeSameAs(mock.Object.AsEnumerable());
        }

        [Test]
        public void GetData_FakeColumn()
        {
            var sortingParams = new SortingParams
            {
                SortField = "DROP",
                SortDir = SortDirection.Desc,
            };

            var randomCategories = new List<Category>();
            var categoryFaker = CategoryFaker.Create();

            randomCategories.AddRange(categoryFaker.GenerateBetween(10, 10));

            var mock = randomCategories.AsQueryable().BuildMock();

            var result = sortingParams.GetData(mock.Object).AsEnumerable();

            result.Should().BeSameAs(mock.Object.AsEnumerable());
        }
    }
}