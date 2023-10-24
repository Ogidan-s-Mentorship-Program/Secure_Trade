using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class CustomerSupport
    {
        public Guid Id = Guid.NewGuid();
        public string Message { get; set; } = string.Empty;
        public Guid UserId { get; set; }
       
    }
}