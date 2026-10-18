using ExamAssignmentApi.Data;
using ExamAssignmentApi.DTOs;
using ExamAssignmentApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamAssignmentApi.Controllers;

[Route("api/checker/requests")]
[ApiController]
//[Authorize(Roles = "Checker")]
public class CheckerController : ControllerBase
{
    private readonly AppDbContext _context;
    public CheckerController(AppDbContext context) => _context = context;

    [HttpGet("pending")]
    public async Task<IActionResult> GetPendingRequests([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        var query = _context.DocumentRequests.Include(r => r.CreatedByUser).Where(r => r.Status == "Pending");
        var totalRecords = await query.CountAsync();
        var data = await query.OrderByDescending(r => r.CreatedAt).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(new PagedResult<DocumentRequest> { Data = data, TotalCount = totalRecords, PageNumber = pageNumber, PageSize = pageSize });
    }

    [HttpPut("{id}/approve")]
    public async Task<IActionResult> ApproveRequest(int id, [FromBody] ReviewActionDto? dto)
    {
        var request = await _context.DocumentRequests.FindAsync(id);
        if (request == null) return NotFound(new { message = "Record not found." });
        if (request.Status != "Pending") return BadRequest(new { message = "Invalid status." });

        if (dto != null && !string.IsNullOrEmpty(dto.Status))
        {
            request.Remarks = dto?.Status ?? "Approved by Checker";
        }
        request.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return Ok(new { message = "Record approved and marked as Checked.", data = request });
    }

    [HttpPut("{id}/reject")]
    public async Task<IActionResult> RejectRequest(int id, [FromBody] ReviewActionDto? dto)
    {
        var request = await _context.DocumentRequests.FindAsync(id);
        if (request == null) return NotFound(new { message = "Record not found." });
        if (request.Status != "Pending") return BadRequest(new { message = "Invalid status." });

        request.Status = "Rejected";
        request.Remarks = dto?.Status ?? "Rejected by Checker";
        request.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return Ok(new { message = "Record rejected by Checker.", data = request });
    }
}
