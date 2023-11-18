using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class Admin
    {
        public Guid Id = Guid.NewGuid();

        [ForeignKey("UserId")]
        public virtual Guid UserId { get; set; }
    }
}
