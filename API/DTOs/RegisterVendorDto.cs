using System.ComponentModel.DataAnnotations;
using Application.Vendor;

namespace API.DTOs
{
    public class RegisterVendorDto
    {
        [Required] public string Username { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$")]
        public string Password { get; set; }

        [Required] public string Name { get; set; }
    }
}