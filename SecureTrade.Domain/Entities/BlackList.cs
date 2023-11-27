using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class BlackList
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsTemporary { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime BlackListAt { get; set; }
        public Guid BlackListBy { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
