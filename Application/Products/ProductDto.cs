using System;
using System.Collections.Generic;

namespace Application.Products
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Unit { get; set; }
        public int Stock { get; set; }
        public Guid UnitTypeId { get; set; }
        public Guid VendorId { get; set; }
        public List<Guid> Categories { get; set; }
    }
}