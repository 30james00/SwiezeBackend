using System.Collections.Generic;
using System.Threading.Tasks;
using Application.UnitTypes;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.UnitTypes
{
    using static Testing;

    public class ListUnitTypeTests : TestBase
    {
        private readonly ListUnitTypeQuery _listUnitTypeQuery = new ListUnitTypeQuery();

        [Test]
        public async Task ListExistingUnitTypes()
        {
            var unitTypes = new[]
            {
                new UnitType { Id = GuidHelper.ToGuid(1), Name = "g" },
                new UnitType { Id = GuidHelper.ToGuid(2), Name = "ml" },
                new UnitType { Id = GuidHelper.ToGuid(3), Name = "unit" },
            };
            foreach (var u in unitTypes)
            {
                await AddAsync(u);
            }

            var result = await SendAsync(_listUnitTypeQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<UnitTypeDto>>();
            result.Value.Should().HaveCount(3);
        }

        [Test]
        public async Task ListEmptyUnitTypes()
        {
            var result = await SendAsync(_listUnitTypeQuery);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<List<UnitTypeDto>>();
            result.Value.Should().HaveCount(0);
        }
    }
}