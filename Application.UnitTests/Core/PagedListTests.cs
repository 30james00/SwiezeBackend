using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Core;
using FluentAssertions;
using MockQueryable.Moq;
using NUnit.Framework;

namespace Application.UnitTests.Core
{
    public class PagedListTests
    {
        [Test]
        public async Task NewPagedList()
        {
            var random = new Random();
            var randomInt = new List<string>();

            for (var i = 0; i < 20; i++)
            {
                randomInt.Add(random.Next().ToString());
            }

            var mock = randomInt.AsQueryable().BuildMock();

            var pagedList = await PagedList <string>.CreateAsync(mock.Object.AsQueryable(), 2, 3);

            pagedList.CurrentPage.Should().Be(2);
            pagedList.PageSize.Should().Be(3);
            pagedList.TotalCount.Should().Be(20);
            pagedList.TotalPages.Should().Be(7);
            pagedList.Should().BeSubsetOf(randomInt);
        }
    }
}