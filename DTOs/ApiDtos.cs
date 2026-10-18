using System.ComponentModel.DataAnnotations;

namespace ExamAssignmentApi.DTOs;

public record LoginDto([Required] string Username, [Required] string Password);
public record TokenResponseDto(string AccessToken, string RefreshToken, string Role);
public record RefreshTokenRequestDto([Required] string AccessToken, [Required] string RefreshToken);
public record CreateDocumentDto(
    [Required(ErrorMessage = "Title is required"), MaxLength(200)] string Title,
    [Required(ErrorMessage = "Content is required")] string Content
);
public record UpdateDocumentDto(
    [Required(ErrorMessage = "Title is required"), MaxLength(200)] string Title,
    [Required(ErrorMessage = "Content is required")] string Content
);
public record ReviewActionDto(string? Status);
public class PagedResult<T>
{
    public IEnumerable<T> Data { get; set; } = new List<T>();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}
