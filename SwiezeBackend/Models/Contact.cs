using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required][MaxLength(128)]
        public string Mail { get; set; }
        [Required][MaxLength(13)]
        public string Phone { get; set; }
        [Required][MaxLength(20)]
        public string Voivodeship { get; set; }
        [Required][MaxLength(6)]
        public string PostalCode { get; set; }
        [Required][MaxLength(40)]
        public string City { get; set; }
        [Required][MaxLength(120)]
        public string Street { get; set; }
        [Required][MaxLength(6)]
        public string HouseNumber { get; set; }
        [MaxLength(4)]
        public string FlatNumber { get; set; }
    }
}