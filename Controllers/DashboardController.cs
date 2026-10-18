using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExamAssignmentApi.Controllers;

[Route("api/dashboard")]
[ApiController]
[Authorize]
public class DashboardController : ControllerBase
{
    [HttpGet]
    public IActionResult GetDashboardMessage()
    {
        var role = User.FindFirstValue(ClaimTypes.Role);
        return role switch
        {
            "User" => Ok(new { message = "This is User Page" }),
            "Checker" => Ok(new { message = "This is Checker Page" }),
            "Authorizer" => Ok(new { message = "This is Authorizer Page" }),
            _ => Forbid()
        };
    }
}
