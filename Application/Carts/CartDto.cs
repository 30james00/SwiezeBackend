using System;

namespace Application.Carts
{
    public class CartDto
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public Guid ProductId { get; set; }
    }
}