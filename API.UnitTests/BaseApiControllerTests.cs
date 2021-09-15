using API.Controllers;
using Application.Core;
using Domain;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Persistence.Faker;

namespace API.UnitTests
{
    public class BaseApiControllerTests : BaseApiController
    {
        [Test]
        public void HandleResult_Null()
        {
            var result = HandleResult<Contact>(null);

            result.Should().BeOfType<NotFoundResult>();
        }

        [Test]
        public void HandleResult_SuccessWithValue()
        {
            var contact = ContactFaker.Create().Generate();
            var result = HandleResult<Contact>(ApiResult<Contact>.Success(contact));

            result.Should().BeOfType<OkObjectResult>();
            result.As<OkObjectResult>().Value.Should().BeOfType<Contact>();
            result.As<OkObjectResult>().Value.Should().BeEquivalentTo(contact);
        }

        [Test]
        public void HandleResult_SuccessWithoutValue()
        {
            var result = HandleResult<Contact>(ApiResult<Contact>.Success(null));

            result.Should().BeOfType<NotFoundResult>();
        }

        [Test]
        public void HandleResult_Failure()
        {
            var result = HandleResult<Contact>(ApiResult<Contact>.Failure("Error"));

            result.Should().BeOfType<BadRequestObjectResult>();
            result.As<BadRequestObjectResult>().Value.Should().Be("Error");
        }
    }
}