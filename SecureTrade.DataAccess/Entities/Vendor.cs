using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.Entities
{
    public class Vendor
    {
        public Guid Id = Guid.NewGuid ();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public DateTime AccountCreationDate { get; set; } 
    
    }
}