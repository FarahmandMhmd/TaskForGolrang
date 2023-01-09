using System.ComponentModel.DataAnnotations;

namespace Portal.Application.Users.Register
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; }=string.Empty;
    }
}