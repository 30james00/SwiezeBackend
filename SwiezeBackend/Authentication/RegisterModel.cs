using System.ComponentModel.DataAnnotations;

namespace SwiezeBackend.Authentication
{
    public class RegisterModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}