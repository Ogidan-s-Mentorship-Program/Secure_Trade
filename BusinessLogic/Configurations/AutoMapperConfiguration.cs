using AutoMapper;
using SecureTrade.Domain.Entities;
using SecureTrade.DTOs.ResponseDTOs.UserResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Configurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<ApplicationUser, RegisterUserResponseDTO>();
        }
    }
}
