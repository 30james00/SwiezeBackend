using System;
using Domain;

namespace Application.Reviews
{
    public class ReviewDto
    {
        public Guid Id { get; set; }
        public int NumberOfStars { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable

        public Guid ClientId { get; set; }

        public Guid VendorId { get; set; }
    }
}