using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? FulfillmentDate { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}