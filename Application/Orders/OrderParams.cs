using System;
using Application.Core;

namespace Application.Orders
{
    public class OrderParams : PagingParams
    {
        public DateTime? MinOrderDate { get; set; }
        public DateTime? MaxOrderDate { get; set; }
        
        public DateTime? MinFulfillmentDate { get; set; }
        public DateTime? MaxFulfillmentDate { get; set; }
        
        public bool? IsCanceled { get; set; }
    }
}