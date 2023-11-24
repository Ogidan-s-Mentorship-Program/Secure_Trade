using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecureTrade.BusinessLogic.Logics.Interfaces;
using SecureTrade.DTOs.ResquestDTOs.UserRequestDTOs;

namespace SecureTrade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUserAsync(RegisterUserRequestDTO registerUserRequestDTO)
        {
            try
            {
               var response = await _userService.RegisterUserAsync(registerUserRequestDTO);
                if (response.Success)
                {
                    return Ok(response);
                }
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
