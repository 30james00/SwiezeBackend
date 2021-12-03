using Application.Core;
using FluentAssertions;
using NUnit.Framework;

namespace Application.UnitTests.Core
{
    public class PagingParamTests
    {
        [Test]
        public void NewDefaultValues()
        {
            var param = new PagingParams
            {
                PageNumber = 20,
                PageSize = 20,
            };

            param.PageNumber.Should().Be(20);
            param.PageNumber.Should().Be(20);
        }
        
        [Test]
        public void NewOverMaxValues()
        {
            var param = new PagingParams
            {
                PageNumber = 20,
                PageSize = 2000,
            };

            param.PageNumber.Should().Be(20);
            param.PageSize.Should().Be(100);
        }
    }
}