using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class PhoneNumber
    {
        public Guid Id = Guid.NewGuid();
        public string CountryCode { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public Guid UserId { get; set; } 
    }
}