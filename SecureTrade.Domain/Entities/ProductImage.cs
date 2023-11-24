using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class ProductImage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Image { get; set; } = string.Empty;

        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
