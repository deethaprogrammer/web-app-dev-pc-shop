using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PcShop.Data;
using PcShop.Models.Identity;

namespace PcShop.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _Db;
    private readonly PasswordHasher<User> _hasher = new();
    public record LoginRequest(string Email, string Password);

    public AuthController(AppDbContext db)
    {
        _Db = db;
    }

    [HttpPost("login")]
    private async Task<IActionResult> Login(LoginRequest req)
    {
        var user = await _Db.Users.FirstOrDefaultAsync(u => u.EmailAddress == req.Email);

        if (user == null || _hasher.VerifyHashedPassword(user, user.PasswordHash, req.Password) == PasswordVerificationResult.Failed)
        {
            return Unauthorized(new { error = "invalid username or password." });
        }

        return Ok(new { user.Id, user.Username });
    }
}
