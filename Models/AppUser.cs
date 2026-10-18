using System.ComponentModel.DataAnnotations;

namespace ExamAssignmentApi.Models;

public class AppUser
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Username { get; set; } = string.Empty;
    [Required]
    public string PasswordHash { get; set; } = string.Empty;
    [Required, MaxLength(20)]
    public string Role { get; set; } = string.Empty;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
}
