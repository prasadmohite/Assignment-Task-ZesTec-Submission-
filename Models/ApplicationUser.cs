using System.ComponentModel.DataAnnotations;

namespace EFCore_CF_01.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        // For local login
        public string? PasswordHash { get; set; }

        // For external login
        public string? Provider { get; set; }         // e.g., "Google"
        public string? ProviderUserId { get; set; }   // Google's user ID

        public string Role { get; set; } = "Employee"; // or "Admin"

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
