using System;

namespace Domain
{
    public class Contact
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

        public Vendor Vendor { get; set; }
        public Guid? VendorId { get; set; }
        public Client Client { get; set; }
        public Guid? ClientId { get; set; }
    }
}