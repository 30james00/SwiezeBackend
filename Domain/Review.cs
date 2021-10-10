using System;

namespace Domain
{
    public class Review
    {
        public Guid Id { get; set; }
        public int NumberOfStars { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable

        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}