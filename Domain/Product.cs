using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public float Unit { get; set; }
        public float Amount { get; set; }

        public Guid UnitTypeId { get; set; }
        public UnitType UnitType { get; set; }

        public Guid VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}