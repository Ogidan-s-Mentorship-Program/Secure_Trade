﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DTOs.ResponseDTOs.UserResponseDTOs
{
    public class ResetPasswordResponseDTO
    {
        public string Token { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

    }
}
