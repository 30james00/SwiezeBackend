using System;
using Application.Contacts;
using Application.Profiles;
using Domain;

namespace Application.Vendor
{
    public class VendorDto
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Guid? ContactId { get; set; }
    }
}