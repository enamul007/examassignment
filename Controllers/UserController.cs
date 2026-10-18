using System.Security.Claims;
using ExamAssignmentApi.Data;
using ExamAssignmentApi.DTOs;
using ExamAssignmentApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamAssignmentApi.Controllers;

[Route("api/user/requests")]
[ApiController]
[Authorize(Roles = "User")]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;
    public UserController(AppDbContext context) => _context = context;
    private int GetCurrentUserId() => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
    [HttpGet]
    public async Task<IActionResult> GetMyRequests([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var userId = GetCurrentUserId();
        var query = _context.DocumentRequests.Where(r => r.CreatedByUserId == userId);
        var totalRecords = await query.CountAsync();
        var data = await query.OrderByDescending(r => r.CreatedAt).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

        return Ok(new PagedResult<DocumentRequest> { Data = data, TotalCount = totalRecords, PageNumber = pageNumber, PageSize = pageSize });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var userId = GetCurrentUserId();
        var item = await _context.DocumentRequests.FirstOrDefaultAsync(r => r.Id == id && r.CreatedByUserId == userId);
        if (item == null) return NotFound(new { message = "Record not found." });
        return Ok(item);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateDocumentDto dto)
    {
        var request = new DocumentRequest
        {
            Title = dto.Title,
            Content = dto.Content,
            Status = "Pending",
            CreatedByUserId = GetCurrentUserId(),
            CreatedAt = DateTime.UtcNow
        };
        _context.DocumentRequests.Add(request);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = request.Id }, request);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateDocumentDto dto)
    {
        var userId = GetCurrentUserId();
        var request = await _context.DocumentRequests.FirstOrDefaultAsync(r => r.Id == id && r.CreatedByUserId == userId);
        if (request == null) return NotFound(new { message = "Record not found." });
        if (request.Status != "Pending") return BadRequest(new { message = "Only 'Pending' records can be modified." });

        request.Title = dto.Title;
        request.Content = dto.Content;
        request.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return Ok(request);
    }
}
