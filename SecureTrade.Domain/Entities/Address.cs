using System;
using System.Collections.Generic;
using System.Linq;
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
        public Guid UserId { get; set; }   
    }
}