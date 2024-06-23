using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NORTHERN_AREAOFPAKISTAN.Models
{
    public class UserSignupandLogin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        public UserRole userRole { get; set; }
        public override string ToString()
        {
            return $"UserSignup: Username={Username}, Email={Email}";
        }
    }
    public enum UserRole
    {
        Administrator=10,
        User=20,
    }
}
