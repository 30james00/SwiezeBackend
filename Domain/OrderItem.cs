using System;

namespace Domain
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public int Value { get; set; }
        
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}