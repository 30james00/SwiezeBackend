using System;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IAccountService
    {
        public Task<AccountInfo> GetAccountInfo();
        public Task<AccountInfo> GetInfoFromUserId(string userId);
    }

    public class AccountInfo
    {
        public AccountType AccountType { get; set; }
        public Guid Id { get; set; }
    }

    public enum AccountType
    {
        Client,
        Vendor
    }
}