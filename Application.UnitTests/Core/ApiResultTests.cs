using NUnit.Framework;
using Persistence.Faker;
using Application.Core;
using Domain;
using FluentAssertions;

namespace Application.UnitTests.Core
{
    public class ApiResultTests
    {
        [Test]
        public void Success_ValidReturn()
        {
            var contact = ContactFaker.Create().Generate();
            var result = ApiResult<Contact>.Success(contact);

            result.IsSuccess.Should().BeTrue();
            result.Error.Should().BeNull();
            result.Value.Should().BeOfType<Contact>();
            result.Value.Should().BeEquivalentTo(contact);
        }

        [Test]
        public void Failure_ValidError()
        {
            var result = ApiResult<Contact>.Failure("Error");

            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("Error");
            result.Value.Should().BeNull();
        }
    }
}