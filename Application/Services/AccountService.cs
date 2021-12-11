using System;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserAccessor _userAccessor;
        private readonly DataContext _context;

        public AccountService(IUserAccessor userAccessor, DataContext context)
        {
            _userAccessor = userAccessor;
            _context = context;
        }

        public async Task<AccountInfo> GetAccountInfo()
        {
            var userId = _userAccessor.GetUserId();
            if (userId == null) throw new Exception("User not logged in");

            return await GetInfoFromUserId(userId);
        }

        public async Task<AccountInfo> GetInfoFromUserId(string userId)
        {
            var account = await _context.Users.Include(x => x.Client).Include(x => x.Vendor)
                .FirstOrDefaultAsync(x => x.Id == userId);

            if (account.Client != null)
            {
                return new AccountInfo
                {
                    AccountType = AccountType.Client,
                    Id = account.Client.Id
                };
            }

            return new AccountInfo
            {
                AccountType = AccountType.Vendor,
                Id = account.Vendor.Id
            };
        }

        public async Task<Guid> GetContactId(string userId)
        {
            return await _context.Contacts.Where(x => x.AccountId == userId).Select(x=>x.Id).FirstOrDefaultAsync();
        }
    }
}