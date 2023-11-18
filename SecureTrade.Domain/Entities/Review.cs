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
        public Guid Id = Guid.NewGuid();
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }
        
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        [ForeignKey("VendorId")]
        public Guid VendorId { get; set; }
        public DateTime RatedAt { get; set; }

        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
    }
}
