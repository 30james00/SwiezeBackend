using System;

namespace API.DTOs
{
    public class AccountDto
    {
        public string Username { get; set; }
        public string Token { get; set; }

        public Guid ClientId { get; set; }
        public Guid VendorId { get; set; }
    }
}