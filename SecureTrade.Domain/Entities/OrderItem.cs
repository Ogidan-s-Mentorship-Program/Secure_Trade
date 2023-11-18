using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id = Guid.NewGuid();
        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public virtual Guid OrderId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Guid ProductId { get; set; }

        [ForeignKey("UserId")]
        public virtual Guid UserId { get; set; }
    }
}
