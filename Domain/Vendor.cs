using System;
using System.Collections.Generic;

namespace Domain
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        public Account Account { get; set; }
#nullable enable
        public string? AccountId { get; set; }
#nullable disable
        public Contact Contact { get; set; }

        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Coupon> Coupons { get; set; }
        public List<Review> Reviews { get; set; }
    }
}