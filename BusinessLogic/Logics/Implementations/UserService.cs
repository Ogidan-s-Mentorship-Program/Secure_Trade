using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NETCore.MailKit.Core;
using Org.BouncyCastle.Asn1.Ocsp;
using SecureTrade.BusinessLogic.Logics.Interfaces;
using SecureTrade.BusinessLogic.Utilities;
using SecureTrade.Domain.Entities;
using SecureTrade.DTOs.ResponseDTOs.UserResponseDTOs;
using SecureTrade.DTOs.ResquestDTOs.UserRequestDTOs;
using SecureTrade.Services.MailServices.Models;
using SecureTrade.Services.MailServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private readonly IEmailServices _emailServices;

        public UserService(UserManager<ApplicationUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager, IEmailServices emailServices)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _emailServices = emailServices;
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

        public async Task<GenericResponse<string>> ForgotPasswordAsync(string email, IHttpContextAccessor httpContextAccessor)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if(user!=null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var resetLink = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}/User/ResetPassword?token={Uri.EscapeDataString(token)}&email={Uri.EscapeDataString(user.Email)}";
                var message = new Message(new string[] { user.Email! }, "Forgot Email link", resetLink!);
                _emailServices.SendEmail(message);

                return GenericResponse<string>.SuccessResponse("Password reset link sent to email successfully");
                //var link = Url.Action("ResetPassword", "User", new { token, email = user.Email }, Request.Scheme);
            }
            return GenericResponse<string>.ErrorResponse("Email not found");
        }





        //public async Task<GenericResponse<ResetEmailRequestDTO>> ForgotPassword(string email)
        //{
        //    var user = await _userManager.FindByEmailAsync(emailRequestDTO);
        //    if (user!=null)
        //    {

        //    }
        //    return GenericResponse<ResetEmailRequestDTO>.ErrorResponse("Email Already Exist");
        //}
    }
}
