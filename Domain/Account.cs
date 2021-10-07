using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Account : IdentityUser
    {
        public Vendor Vendor { get; set; }
        public Contact Contact { get; set; }
    }
}