using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureTrade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureTrade.DataAccess.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.ZipCode)
                .HasMaxLength(10);

            builder.Property(a => a.StreetNo)
                .HasMaxLength(5);
            
            builder.Property(a => a.Street)
                .HasMaxLength(255);

            builder.Property(a => a.City)
                .HasMaxLength(50);

            builder.Property(a => a.State)
                .HasMaxLength(50);

            builder.Property(a => a.Country)
                .HasMaxLength(50);

            builder.Property(a => a.UserId)
                .IsRequired();

            builder.HasOne(a => a.User)
               .WithMany()
               .HasForeignKey(a => a.UserId)
                               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
