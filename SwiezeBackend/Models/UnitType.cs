using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class UnitType
    {
        public int UnitTypeId { get; set; }

        [Required] [MaxLength(30)] public string Name { get; set; }

        public Product Product { get; set; }
    }
}