using System;
using System.Collections.Generic;

namespace Domain
{
    public class Cart
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }

        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}