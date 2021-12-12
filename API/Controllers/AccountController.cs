using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.DTOs;
using API.Services;
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public AccountController(UserManager<Account> userManager, SignInManager<Account> signInManager,
            ITokenService tokenService, DataContext context, IAccountService accountService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _context = context;
            _accountService = accountService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<AccountDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Mail);

            if (user == null) return Unauthorized();

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (result.Succeeded)
            {
                await SetRefreshToken(user);
                return await CreateAccountDto(user);
            }

            return Unauthorized();
        }

        [AllowAnonymous]
        [HttpPost("register/client")]
        public async Task<ActionResult<AccountDto>> RegisterClient(RegisterClientDto registerClientDto)
        {
            if (await _userManager.Users.AnyAsync(x => x.Email == registerClientDto.Mail))
            {
                return BadRequest("Email taken");
            }

            if (await _userManager.Users.AnyAsync(x => x.UserName == registerClientDto.Username))
            {
                return BadRequest("Username taken");
            }

            var user = new Account
            {
                UserName = registerClientDto.Username,
                Email = registerClientDto.Mail,
            };
            var result = await _userManager.CreateAsync(user, registerClientDto.Password);

            var client = new Client
            {
                FirstName = registerClientDto.FirstName,
                LastName = registerClientDto.LastName,
                AccountId = user.Id,
            };

            await _context.Clients.AddAsync(client);
            var resultClient = await _context.SaveChangesAsync() > 0;

            if (!resultClient)
                return BadRequest("Problem creating Client");

            if (result.Succeeded)
            {
                await SetRefreshToken(user);
                return await CreateAccountDto(user);
            }

            return BadRequest("Problem registering user");
        }

        [AllowAnonymous]
        [HttpPost("register/vendor")]
        public async Task<ActionResult<AccountDto>> RegisterVendor(RegisterVendorDto registerVendorDto)
        {
            if (await _userManager.Users.AnyAsync(x => x.Email == registerVendorDto.Mail))
            {
                return BadRequest("Email taken");
            }

            if (await _userManager.Users.AnyAsync(x => x.UserName == registerVendorDto.Username))
            {
                return BadRequest("Username taken");
            }

            var user = new Account
            {
                UserName = registerVendorDto.Username,
                Email = registerVendorDto.Mail,
            };
            var result = await _userManager.CreateAsync(user, registerVendorDto.Password);

            var vendor = new Vendor
            {
                Name = registerVendorDto.Name,
                AccountId = user.Id,
            };

            await _context.Vendors.AddAsync(vendor);
            var resultVendor = await _context.SaveChangesAsync() > 0;

            if (!resultVendor)
                return BadRequest("Problem creating Vendor");

            if (result.Succeeded)
            {
                await SetRefreshToken(user);
                return await CreateAccountDto(user);
            }

            return BadRequest("Problem registering user");
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<AccountDto>> GetCurrentUser()
        {
            var user = await _userManager.FindByEmailAsync(User.FindFirstValue(ClaimTypes.Email));

            return await CreateAccountDto(user);
        }

        [Authorize]
        [HttpPost("refresh-token")]
        public async Task<ActionResult<AccountDto>> RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            var user = await _userManager.Users.Include(r => r.RefreshTokens)
                .FirstOrDefaultAsync(x => x.UserName == User.FindFirstValue(ClaimTypes.Name));

            if (user == null) return Unauthorized();

            var oldToken = user.RefreshTokens.SingleOrDefault(x => x.Token == refreshToken);

            if (oldToken is { IsActive: false }) return Unauthorized();

            return await CreateAccountDto(user);
        }


        private async Task SetRefreshToken(Account user)
        {
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshTokens.Add(refreshToken);
            await _userManager.UpdateAsync(user);

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7),
            };

            Response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);
        }

        private async Task<AccountDto> CreateAccountDto(Account account)
        {
            //check Account type
            var accountInfo = await _accountService.GetInfoFromUserId(account.Id);

            var accountDto = new AccountDto
            {
                Username = account.UserName,
                Token = _tokenService.CreateToken(account),
            };

            //set fields according to Account type
            if (accountInfo.AccountType == AccountType.Client)
                accountDto.ClientId = accountInfo.Id;
            else accountDto.VendorId = accountInfo.Id;

            accountDto.ContactId = await _accountService.GetContactId(account.Id);

            return accountDto;
        }
    }
}