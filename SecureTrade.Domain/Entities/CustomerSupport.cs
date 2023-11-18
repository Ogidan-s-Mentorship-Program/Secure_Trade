using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class CustomerSupport
    {
        public Guid Id = Guid.NewGuid();
        public string Message { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public virtual Guid UserId { get; set; }
    }
}
