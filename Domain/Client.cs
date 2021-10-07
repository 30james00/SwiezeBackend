using System;

namespace Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Account Account { get; set; }
#nullable enable
        public string? AccountId { get; set; }
#nullable disable
        public Contact Contact { get; set; }
    }
}