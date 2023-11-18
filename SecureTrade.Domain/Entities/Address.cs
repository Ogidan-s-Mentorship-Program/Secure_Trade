using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class Address
    {
        public Guid Id = Guid.NewGuid();
        public int StreetNo { get; set; }
        public string Street { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public virtual Guid UserId { get; set; }
    }
}
