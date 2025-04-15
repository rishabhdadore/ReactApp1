using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactApp1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public class SignUpModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        // POST: api/user/signup
        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] SignUpModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name) || string.IsNullOrWhiteSpace(model.Email))
                return BadRequest("Name and Email are required.");

            // Here, you would save the user data to the database in future.
            // For now, we are just simulating a successful registration.
            return Ok(new { message = "User successfully registered!" });
        }
    }
}
