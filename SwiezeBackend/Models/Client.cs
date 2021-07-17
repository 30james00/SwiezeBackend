using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required] [MaxLength(60)] public string FirstName { get; set; }

        [Required] [MaxLength(60)] public string LastName { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}