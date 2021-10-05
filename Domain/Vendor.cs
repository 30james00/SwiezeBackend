using System;

namespace Domain
{
    public class Vendor
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        public Account Account { get; set; }
#nullable enable
        public string? AccountId { get; set; }
#nullable disable
        public Contact Contact { get; set; }
    }
}