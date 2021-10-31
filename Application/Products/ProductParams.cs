using System;
using Application.Core;

namespace Application.Products
{
    public class ProductParams : PagingParams
    {
        public string Name { get; set; }

        public int MinValue { get; set; } = 0;
        public int MaxValue { get; set; } = 0;

        public int MinUnit { get; set; } = 0;
        public int MaxUnit { get; set; } = 0;

        public Guid Category { get; set; }
    }
}