using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamAssignmentApi.Models;

public class DocumentRequest
{
    public int Id { get; set; }
    [Required, MaxLength(200)]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Content { get; set; } = string.Empty;
    [Required, MaxLength(20)]
    public string Status { get; set; } = "Pending";
    [MaxLength(500)]
    public string? Remarks { get; set; }
    public int CreatedByUserId { get; set; }
    [ForeignKey("CreatedByUserId")]
    public AppUser? CreatedByUser { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
