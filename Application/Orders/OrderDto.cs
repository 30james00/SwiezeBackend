using System;
using System.Collections.Generic;

namespace Application.Orders
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? FulfillmentDate { get; set; }

        public Guid ClientId { get; set; }

        public Guid VendorId { get; set; }

        public List<Guid> Products { get; set; }
    }
}