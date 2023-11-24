using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SecureTrade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.EntityConfiguration
{
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.HasKey(pn => pn.Id);

            builder.Property(pn => pn.CountryCode)
                .HasMaxLength(10);

            builder.Property(pn => pn.Number)
                .HasMaxLength(20); 

            builder.Property(pn => pn.UserId)
                .IsRequired();

            builder.HasOne(pn => pn.User)
                .WithMany()
                .HasForeignKey(pn => pn.UserId)
                                .OnDelete(DeleteBehavior.NoAction);

        }
    }

}
