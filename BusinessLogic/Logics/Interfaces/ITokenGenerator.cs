using SecureTrade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.BusinessLogic.Logics.Interfaces
{
    public interface ITokenGenerator
    {
        Task<string> GenerateTokenAsync(ApplicationUser user);
    }
}
