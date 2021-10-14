using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterVendorDto
    {
        [Required] public string Username { get; set; }
        [Required] [EmailAddress] public string Mail { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$")]
        public string Password { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}