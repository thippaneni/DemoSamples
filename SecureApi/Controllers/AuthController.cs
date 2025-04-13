using Microsoft.AspNetCore.Mvc;
using SecureApi.Configuration;
using SecureApi.Models;
using SecureApi.Request;
using SecureApi.Services;

namespace SecureApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(IJwtService _jwtService) : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Dummy validation            
            if (request.Username == request.Password &&
                (request.Username == "admin" || request.Username == "dev"
                || request.Username == "qa" || request.Username == "user")) 
            {
                var user = new User() { Username = request.Username };
                if (request.Password == "admin")
                {
                    user.Role = "Admin";
                }
                else if (request.Password == "dev")
                {
                    user.Role = "Dev";
                }
                else if (request.Password == "qa")
                {
                    user.Role = "QA";
                }
                else
                {
                    user.Role = "User";
                }

                var token = _jwtService.GenerateToken(user);
                return Ok(new { token });
            }
            else
            {
                return Unauthorized("Invalid username or password.");                
            }            
        }
    }
}
