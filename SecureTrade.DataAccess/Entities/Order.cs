using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class Order
    {
         public Guid Id = Guid.NewGuid();
        public DateTime OrderDate { get; set; } 
        public Decimal TotalAmount { get; set; } 
        public Guid UserId { get; set; } 
    }
}