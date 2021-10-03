using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Account : IdentityUser
    {
        public Vendor Vendor { get; set; }
    }
}