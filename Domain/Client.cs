using System;
using System.Collections.Generic;

namespace Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Account Account { get; set; }
#nullable enable
        public string? AccountId { get; set; }
#nullable disable
        public Contact Contact { get; set; }

        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
    }
}