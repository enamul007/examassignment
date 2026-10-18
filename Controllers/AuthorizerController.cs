using ExamAssignmentApi.Data;
using ExamAssignmentApi.DTOs;
using ExamAssignmentApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamAssignmentApi.Controllers;

[Route("api/authorizer/requests")]
[ApiController]

public class AuthorizerController : ControllerBase
{
    private readonly AppDbContext _context;
    public AuthorizerController(AppDbContext context) => _context = context;

    [HttpGet("checked")]
    [Authorize(Roles = "Authorizer, Checker")]
    public async Task<IActionResult> GetCheckedRequests([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string status = "")
    {
        var query = _context.DocumentRequests.Include(r => r.CreatedByUser).Where(r => r.Status == status);
        var totalCount = await query.CountAsync();
        var data = await query.OrderByDescending(r => r.UpdatedAt).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(new PagedResult<DocumentRequest> { Data = data, TotalCount = totalCount, PageNumber = pageNumber, PageSize = pageSize });
    }

    [HttpPut("{id}/authorize")]
    public async Task<IActionResult> AuthorizeRequest(int id, [FromBody] ReviewActionDto? dto)
    {
        var request = await _context.DocumentRequests.FindAsync(id);
        if (request == null) return NotFound(new { message = "Record not found." });
       // if (request.Status != "Checked") return BadRequest(new { message = "Must be Checked status." });

        //request.Status = "Authorized";
        //request.Remarks = dto?.Status ?? "Authorized";
        if (dto != null && !string.IsNullOrEmpty(dto.Status))
        {
            if (request.Status != dto?.Status)
            {
                request.Status = dto?.Status ?? "Approved by Checker";
            }
            
        }
        request.UpdatedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return Ok(new { message = "Record successfully Authorized.", data = request });
    }
}
