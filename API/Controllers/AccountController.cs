using System;
using System.Security.Claims;
using System.Threading.Tasks;
using API.DTOs;
using API.Services;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly DataContext _context;

        public AccountController(UserManager<Account> userManager, SignInManager<Account> signInManager,
            ITokenService tokenService, DataContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AccountDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if (user == null) return Unauthorized();

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (result.Succeeded)
            {
                return CreateAccountDto(user);
            }

            return Unauthorized();
        }

        [HttpPost("register/vendor")]
        public async Task<ActionResult<AccountDto>> Register(RegisterVendorDto registerVendorDto)
        {
            if (await _userManager.Users.AnyAsync(x => x.Email == registerVendorDto.Email))
            {
                return BadRequest("Email taken");
            }

            if (await _userManager.Users.AnyAsync(x => x.UserName == registerVendorDto.Username))
            {
                return BadRequest("Username taken");
            }

            var user = new Account
            {
                //Id = Guid.NewGuid().ToString(),
                UserName = registerVendorDto.Username,
                Email = registerVendorDto.Email,
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
                return CreateAccountDto(user);
            }

            return BadRequest("Problem registering user");
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<AccountDto>> GetCurrentUser()
        {
            var user = await _userManager.FindByEmailAsync(User.FindFirstValue(ClaimTypes.Email));

            return CreateAccountDto(user);
        }

        private AccountDto CreateAccountDto(Account account)
        {
            return new AccountDto
            {
                Username = account.UserName,
                Token = _tokenService.CreateToken(account),
            };
        }
    }
}