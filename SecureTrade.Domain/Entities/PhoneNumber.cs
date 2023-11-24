﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.Domain.Entities
{
    public class PhoneNumber
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CountryCode { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
