using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Contracts;
using WebApplication3.Data;
using WebApplication3.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAll()
        {
            return Ok(await _userRepository.GetAll());
        }

        [HttpPost("addUser")]
        public async Task<IActionResult> AddUser([FromBody]AddUserDTO userDto)
        {
           await _userRepository.CreateUserAsync(userDto);
            return Ok("User Created Successfully");
        }
    }
}
