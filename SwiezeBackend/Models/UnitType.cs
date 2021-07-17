using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class UnitType
    {
        public int UnitTypeId { get; set; }

        [Required] [MaxLength(60)] public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}