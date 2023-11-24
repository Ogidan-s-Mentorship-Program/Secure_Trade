using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SecureTrade.BusinessLogic.Logics.Interfaces;
using SecureTrade.BusinessLogic.Utilities;
using SecureTrade.Domain.Entities;
using SecureTrade.DTOs.ResponseDTOs.UserResponseDTOs;
using SecureTrade.DTOs.ResquestDTOs.UserRequestDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Logics.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<ApplicationUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task<GenericResponse<RegisterUserResponseDTO>> RegisterUserAsync(RegisterUserRequestDTO registerUserRequestDTO)
        {
            var userExist = await _userManager.FindByEmailAsync(registerUserRequestDTO.Email);

            if (userExist == null)
            {
                
                ApplicationUser user = new()
                {
                    FirstName = registerUserRequestDTO.FirstName,
                    LastName = registerUserRequestDTO.LastName,
                    MiddleName = registerUserRequestDTO.MiddleName,
                    Email = registerUserRequestDTO.Email,
                    UserName = registerUserRequestDTO.Email.Split('@')[0],
                    EmailConfirmed = true
                };

                IdentityResult result = await _userManager.CreateAsync(user, registerUserRequestDTO.Password);

                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync(Constants.Roles.Customer))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Constants.Roles.Customer));
                    }

                    if (await _roleManager.RoleExistsAsync(Constants.Roles.Customer))
                    {
                        await _userManager.AddToRoleAsync(user, Constants.Roles.Customer);
                    }

                    var response = _mapper.Map<RegisterUserResponseDTO>(user);

                    return GenericResponse<RegisterUserResponseDTO>.SuccessResponse(response, "Account Created Sucessfully");
                }
                return GenericResponse<RegisterUserResponseDTO>.ErrorResponse("Account Creation Failed");

            }
            return GenericResponse<RegisterUserResponseDTO>.ErrorResponse("Email Already Exist");
        }
    }
}
