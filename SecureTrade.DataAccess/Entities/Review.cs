using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class Review
    {
        public Guid Id = Guid.NewGuid();
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; } 
        public Guid RatedBy = Guid.NewGuid();
        public User? ReviewOwner { get; set; }
        public DateTime RatedAt { get; set; }
        public Guid ProductId { get; set;}
     
        
    }
}