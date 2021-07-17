using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required] [MaxLength(30)] public string Name { get; set; }

        [Required] public int Value { get; set; }

        [Required] public int Unit { get; set; }

        [Required] public int Amount { get; set; }
        
        public int UnitTypeId { get; set; }
        public UnitType UnitType { get; set; }
    }
}