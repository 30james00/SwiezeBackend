using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Account : IdentityUser
    {
        public Vendor Vendor { get; set; }
        public Client Client { get; set; }
    }
}