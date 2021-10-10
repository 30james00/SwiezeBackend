using System;

namespace Domain
{
    public class Coupon
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public int Amount { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable
        public int? AmountOfUses { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}