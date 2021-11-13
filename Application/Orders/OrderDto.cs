using System;
using System.Collections.Generic;

namespace Application.Orders
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? FulfillmentDate { get; set; }
        public bool IsCanceled { get; set; }

        public Guid ClientId { get; set; }
        public Guid VendorId { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }

    public class OrderItemDto
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public int Value { get; set; }
        public Guid ProductId { get; set; }
    }
}