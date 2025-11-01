using Architecture_V4.BusinessLogic.Services;
using Architecture_V4.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(IUnitOfWork unitOfWork)
        {
            _userService = new UserService(unitOfWork);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRequest request)
        {
            await _userService.RegisterUserAsync(request.Name, request.Email);
            return Ok("User created successfully.");
        }
    }

    public class UserRequest
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
    }

}
