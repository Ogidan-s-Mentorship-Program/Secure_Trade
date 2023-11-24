using SecureTrade.DTOs.ResponseDTOs.UserResponseDTOs;
using SecureTrade.DTOs.ResquestDTOs.UserRequestDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Logics.Interfaces
{
    public interface IUserService
    {
        Task<GenericResponse<RegisterUserResponseDTO>> RegisterUserAsync(RegisterUserRequestDTO registerUserRequestDTO);
    }
}
