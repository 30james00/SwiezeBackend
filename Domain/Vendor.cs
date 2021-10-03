using System;

namespace Domain
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        
        public Contact Contact { get; set; }
    }
}