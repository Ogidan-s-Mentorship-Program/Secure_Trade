using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class User
    {
        public Guid Id = Guid.NewGuid();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public int StreetNo { get; set; }
        public string Street { get; set; } = string.Empty; 
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty; 
        public string City { get; set; } = string.Empty; 
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }
}