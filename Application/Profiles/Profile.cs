using Application.Vendor;

namespace Application.Profiles
{
    public class Profile
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public VendorDto Vendor { get; set; }
    }
}