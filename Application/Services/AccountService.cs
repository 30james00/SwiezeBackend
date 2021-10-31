using System;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly DataContext _context;

        public AccountService(DataContext context)
        {
            _context = context;
        }

        public async Task<AccountInfo> GetAccountInfo(string userId)
        {
            var clientId = await _context.Clients.Where(x => x.AccountId == userId).Select(x => x.Id)
                .FirstOrDefaultAsync();

            if (clientId != Guid.Empty)
            {
                return new AccountInfo
                {
                    AccountType = AccountType.Client,
                    Id = clientId,
                };
            }

            var vendorId = await _context.Vendors.Where(x => x.AccountId == userId).Select(x => x.Id)
                .FirstOrDefaultAsync();

            return new AccountInfo
            {
                AccountType = AccountType.Vendor,
                Id = vendorId,
            };
        }
    }
}