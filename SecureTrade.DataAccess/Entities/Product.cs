using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class Product
    {
        public Guid Id = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string StockQuantity { get; set;} = string.Empty;
        public bool IsSold { get; set; }
        public int Views { get; set; }
        public string City { get; set;} = string.Empty;
        public string State { get; set;} = string.Empty;
        public string Country { get; set;} = string.Empty;
        public DateTime UploadedAt { get; set; }
        public DateTime EditedAt { get; set; }
        public Guid UpdatedBy = Guid.NewGuid();
        public Guid UserId { get; set;}
        
    }
}