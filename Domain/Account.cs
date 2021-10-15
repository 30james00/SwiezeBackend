using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Account : IdentityUser
    {
        public Client Client { get; set; }
        public Contact Contact { get; set; }
        public Vendor Vendor { get; set; }
    }
}