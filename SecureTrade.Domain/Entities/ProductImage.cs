using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class ProductImage
    {
        public Guid Id = Guid.NewGuid();
        public string Image { get; set; } = string.Empty;
        public Guid ProductId { get; set; }  
    }
}