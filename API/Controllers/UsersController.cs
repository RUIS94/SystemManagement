using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] User user)
        {
            await _userService.AddUserAsync(user);
            return CreatedAtAction(nameof(GetAllUsers), new { id = user.UserID }, user);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser([FromBody] User user)
        {
            await _userService.UpdateUserAsync(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(string id)
        {
            await _userService.DeleteUserAsync(id);
            return NoContent();
        }

        [HttpGet("role")]
        public async Task<ActionResult<string>> GetRole(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return BadRequest("Username and password are required.");
            }
            try
            {
                var role = await _userService.GetUserRoleAsync(username, password);
                return Ok(role);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{term}")]
        public async Task<ActionResult<List<User>>> SearchUsers(string term)
        {
            var users = await _userService.GetUsersByTermAsync(term);
            if (users.Count == 0)
            {
                return NotFound("No users found.");
            }
            return Ok(users);
        }
        //[HttpGet("UserID")]
        //public async Task<ActionResult<string>> GetUserID()
        //{
        //    string newUserID = await _userService.GenerateNewUserIDAsync();
        //    return Ok(newUserID);
        //}

        //[HttpPost("updatePassword")]
        //public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordRequest request)
        //{
        //    await _userService.UpdateUserPasswordAsync(request.Username, request.Password);
        //    return Ok();
        //}

        //[HttpPost("updatePhone")]
        //public async Task<IActionResult> UpdatePhone([FromBody] UpdatePhoneRequest request)
        //{
        //    await _userService.UpdateUserPhoneAsync(request.Username, request.Phone);
        //    return Ok();
        //}

        //[HttpPost("updateRole")]
        //public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleRequest request)
        //{
        //    await _userService.UpdateUserRoleAsync(request.Username, request.Role);
        //    return Ok();
        //}
    }
}
