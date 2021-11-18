using System;

namespace Domain
{
    public class Review
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public int NumberOfStars { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}