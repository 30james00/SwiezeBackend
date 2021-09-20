using API.Services;
using FluentAssertions;
using NUnit.Framework;
using Persistence.Faker;

namespace API.UnitTests
{
    public class TokenServiceTests
    {
        [Test]
        public void CreateToken()
        {
            var account = AccountFaker.Create().Generate();

            var tokenService = new TokenService();
            var result = tokenService.CreateToken(account);

            result.Should().BeOfType<string>();
            result.Should().NotBeEmpty();
        }
    }
}