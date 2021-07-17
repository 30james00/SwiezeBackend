using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required] [MaxLength(60)] public string Firstname { get; set; }

        [Required] [MaxLength(60)] public string Lastname { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}