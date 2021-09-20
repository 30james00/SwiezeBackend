using System;
using System.Threading.Tasks;
using API.Controllers;
using API.DTOs;
using API.Services;
using Domain;
using FluentAssertions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace API.UnitTests
{
    public class AccountControllerTests
    {
        private Mock<ITokenService> _tokenService = new Mock<ITokenService>();

        public class FakeUserManager : UserManager<Account>
        {
            public FakeUserManager()
                : base(new Mock<IUserStore<Account>>().Object,
                    new Mock<IOptions<IdentityOptions>>().Object,
                    new Mock<IPasswordHasher<Account>>().Object,
                    Array.Empty<IUserValidator<Account>>(),
                    Array.Empty<IPasswordValidator<Account>>(),
                    new Mock<ILookupNormalizer>().Object,
                    new Mock<IdentityErrorDescriber>().Object,
                    new Mock<IServiceProvider>().Object,
                    new Mock<ILogger<UserManager<Account>>>().Object)
            {
            }
        }

        public class FakeSignInManager : SignInManager<Account>
        {
            public FakeSignInManager()
                : base(new FakeUserManager(),
                    new Mock<IHttpContextAccessor>().Object,
                    new Mock<IUserClaimsPrincipalFactory<Account>>().Object,
                    new Mock<IOptions<IdentityOptions>>().Object,
                    new Mock<ILogger<SignInManager<Account>>>().Object,
                    new Mock<IAuthenticationSchemeProvider>().Object,
                    new Mock<IUserConfirmation<Account>>().Object)
            {
            }
        }

        [SetUp]
        public void SetUp()
        {
            _tokenService.Setup(x => x.CreateToken(It.IsAny<Account>())).Returns("Token");
        }


        [Test]
        public async Task Login_ValidData()
        {
            var loginDto = new LoginDto
            {
                Email = "test@test.com",
                Password = "Pa$$w0rd",
            };

            var userManager = new Mock<FakeUserManager>();
            userManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(new Account
                {
                    UserName = "User",
                });

            var signInManager = new Mock<FakeSignInManager>();
            signInManager.Setup(x =>
                    x.CheckPasswordSignInAsync(It.IsAny<Account>(), It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(SignInResult.Success);

            var accountController =
                new AccountController(userManager.Object, signInManager.Object, _tokenService.Object);

            var result = await accountController.Login(loginDto);

            result.Value.Username.Should().Be("User");
            result.Value.Token.Should().Be("Token");
        }

        [Test]
        public async Task Login_InvalidEmail()
        {
            var loginDto = new LoginDto
            {
                Email = "test@test.com",
                Password = "Pa$$w0rd",
            };

            var userManager = new Mock<FakeUserManager>();
            userManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync((Account)null);

            var signInManager = new Mock<FakeSignInManager>();

            var accountController =
                new AccountController(userManager.Object, signInManager.Object, _tokenService.Object);

            var result = await accountController.Login(loginDto);

            result.Result.Should().BeOfType<UnauthorizedResult>();
        }

        [Test]
        public async Task Login_InvalidPassword()
        {
            var loginDto = new LoginDto
            {
                Email = "test@test.com",
                Password = "Pa$$w0rd",
            };

            var userManager = new Mock<FakeUserManager>();
            userManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(new Account
                {
                    UserName = "User",
                });

            var signInManager = new Mock<FakeSignInManager>();
            signInManager.Setup(x =>
                    x.CheckPasswordSignInAsync(It.IsAny<Account>(), It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(SignInResult.Failed);

            var accountController =
                new AccountController(userManager.Object, signInManager.Object, _tokenService.Object);

            var result = await accountController.Login(loginDto);

            result.Result.Should().BeOfType<UnauthorizedResult>();
        }
    }
}