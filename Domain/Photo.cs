﻿using System;

namespace Domain
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}