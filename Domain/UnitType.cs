using System;
using System.Collections.Generic;

namespace Domain
{
    public class UnitType
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        public List<Product> Products { get; set; }
    }
}