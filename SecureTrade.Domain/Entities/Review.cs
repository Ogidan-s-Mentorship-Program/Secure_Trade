using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class Review
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [ForeignKey("VendorId")]
        public Guid VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public DateTime RatedAt { get; set; }

        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
