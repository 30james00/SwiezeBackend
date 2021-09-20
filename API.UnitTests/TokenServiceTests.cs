using API.Services;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using Persistence.Faker;

namespace API.UnitTests
{
    public class TokenServiceTests
    {
        [Test]
        public void CreateToken()
        {
            var config = new Mock<IConfiguration>();
            config.Setup(x => x["TokenKey"]).Returns("very secur password");
            
            var account = AccountFaker.Create().Generate();

            var tokenService = new TokenService(config.Object);
            var result = tokenService.CreateToken(account);

            result.Should().BeOfType<string>();
            result.Should().NotBeEmpty();
        }
    }
}