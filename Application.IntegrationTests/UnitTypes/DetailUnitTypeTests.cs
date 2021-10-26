using System.Threading.Tasks;
using Application.Categories;
using Application.Core;
using Application.UnitTypes;
using Domain;
using FluentAssertions;
using NUnit.Framework;
using Persistence;

namespace Application.IntegrationTests.UnitTypes
{
    using static Testing;

    public class DetailUnitTypeTests : TestBase
    {
        private readonly UnitType _unitType = new UnitType
        {
            Id = GuidHelper.ToGuid(1),
            Name = "Test",
        };
        
        [Test]
        public async Task DetailExistingUnitType()
        {
            await AddAsync(_unitType);

            var query = new DetailUnitTypeQuery(GuidHelper.ToGuid(1));

            var result = await SendAsync(query);

            result.IsSuccess.Should().BeTrue();
            result.Value.Should().BeOfType<UnitTypeDto>();
            result.Value.Name.Should().Be("Test");
        }

        [Test]
        public async Task DetailNonExistingUnitType()
        {
            var query = new DetailUnitTypeQuery(GuidHelper.ToGuid(1));
            var result = await SendAsync(query);
            result.Should().BeOfType<ApiResult<UnitTypeDto>>();
            result.Value.Should().BeNull();
        }
    }
}