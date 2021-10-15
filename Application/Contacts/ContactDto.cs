using System;
using Application.Vendor;
using Domain;

namespace Application.Contacts
{
    public class ContactDto
    {
        public Guid Id { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Voivodeship { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string FlatNumber { get; set; }

        public string AccountId { get; set; }
    }
}