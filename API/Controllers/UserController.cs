using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecureTrade.BusinessLogic.Logics.Interfaces;
using SecureTrade.DTOs.ResponseDTOs.UserResponseDTOs;
using SecureTrade.DTOs.ResquestDTOs.UserRequestDTOs;
using System.ComponentModel.DataAnnotations;

namespace SecureTrade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
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

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordResponseDTO { Token = token, Email = email };
            return Ok(new { model });
        }


        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([Required] string email)
        {
            try
            {
                var response = await _userService.ForgotPasswordAsync(email, _httpContextAccessor);

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
