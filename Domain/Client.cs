using System;
using System.Collections.Generic;

namespace Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Account Account { get; set; }
#nullable enable
        public string? AccountId { get; set; }
#nullable disable

        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<Review> Reviews { get; set; }
    }
}