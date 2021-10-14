using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterClientDto
    {
        [Required] public string Username { get; set; }
        [Required] [EmailAddress] public string Mail { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$")]
        public string Password { get; set; }

        [Required] [MaxLength(60)] public string FirstName { get; set; }

        [Required] [MaxLength(60)] public string LastName { get; set; }
    }
}