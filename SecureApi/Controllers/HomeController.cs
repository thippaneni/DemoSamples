using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult Public() => Ok("This is a public endpoint.");

        [Authorize]
        [HttpGet("protected")]
        public IActionResult Protected() => Ok($"This is protected. User: {User.Identity?.Name}");

        [Authorize(Roles = "Admin")]
        [HttpGet("admin")]
        public IActionResult AdminOnly() => Ok("This is only for Admins.");

        [Authorize(Roles = "Dev,Admin")]
        [HttpGet("dev")]
        public IActionResult DevOnly() => Ok("This is only for Developers or Admins");

        [Authorize(Roles = "QA,Admin")]
        [HttpGet("qa")]
        public IActionResult QaOnly() => Ok("This is only for QAs or Admins");
    }
}
