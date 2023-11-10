using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class BlackList
    {
        public Guid Id = Guid.NewGuid();
        public Guid UserId { get; set; }
        public bool IsTemporary { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime BlackListAt { get; set; }
        public Guid BlackListBy { get; set; }
    }
}