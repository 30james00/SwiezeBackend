using System;
using System.Collections.Generic;
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
        private Mock<FakeUserManager> _userManager = new Mock<FakeUserManager>();
        private Mock<FakeSignInManager> _signInManager = new Mock<FakeSignInManager>();
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

        private AccountController GetAccountController()
        {
            return new AccountController(_userManager.Object, _signInManager.Object, _tokenService.Object);
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

            _userManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(new Account
                {
                    UserName = "User",
                });

            _signInManager.Setup(x =>
                    x.CheckPasswordSignInAsync(It.IsAny<Account>(), It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(SignInResult.Success);

            var result = await GetAccountController().Login(loginDto);

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

            _userManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync((Account)null);

            var result = await GetAccountController().Login(loginDto);

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

            _userManager.Setup(x => x.FindByEmailAsync(It.IsAny<string>()))
                .ReturnsAsync(new Account
                {
                    UserName = "User",
                });

            _signInManager.Setup(x =>
                    x.CheckPasswordSignInAsync(It.IsAny<Account>(), It.IsAny<string>(), It.IsAny<bool>()))
                .ReturnsAsync(SignInResult.Failed);

            var result = await GetAccountController().Login(loginDto);

            result.Result.Should().BeOfType<UnauthorizedResult>();
        }
    }
}