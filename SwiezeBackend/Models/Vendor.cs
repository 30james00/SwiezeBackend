using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }

        [Required] [MaxLength(60)] public string Name { get; set; }

        //relations
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        
        public List<Product> Products { get; set; }
    }
}